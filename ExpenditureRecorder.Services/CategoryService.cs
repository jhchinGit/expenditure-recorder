using ExpenditureRecorder.Data.Exceptions;
using ExpenditureRecorder.Model;
using System.Collections.Generic;
using System.Linq;

namespace ExpenditureRecorder.Services
{
    public class CategoryService
    {
        private readonly List<Category> _categories;

        public CategoryService()
        {
            _categories = new List<Category>();
        }

        public Category Create(string name)
        {
            ValidateName(name);
            Category category = new(GetNewId(), name);
            _categories.Add(category);

            return category;
        }

        private void ValidateName(string name)
        {
            if (name == null)
            {
                throw new CategoryNameCannotBeEmptyOrNull();
            }

            bool isNameDuplicated = _categories.Any(c => c.Name.ToLower() == name.ToLower());

            if (isNameDuplicated)
            {
                throw new CategoryNameInUsedException();
            }
        }

        private long GetNewId()
        {
            return _categories.Count + 1;
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public Category Update(Category category)
        {
            ValidateExistingName(category.Id, category.Name);
            Category category1 = _categories.SingleOrDefault(
                c => c.Id == category.Id);

            if (category1 == null)
            {
                throw new CategoryNotFoundException();
            }

            category1.Name = category.Name;
            return category1;
        }

        private void ValidateExistingName(long id, string name)
        {
            if (name == null)
            {
                throw new CategoryNameCannotBeEmptyOrNull();
            }

            bool isNameDuplicated = _categories
                .Any(c => c.Name.ToLower() == name.ToLower() &&
                c.Id != id);

            if (isNameDuplicated)
            {
                throw new CategoryNameInUsedException();
            }
        }
    }
}