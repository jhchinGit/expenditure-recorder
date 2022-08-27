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
            Category category = new(name);
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

        public List<Category> GetAll()
        {
            return _categories;
        }
    }
}