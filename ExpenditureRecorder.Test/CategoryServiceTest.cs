using ExpenditureRecorder.Data.Exceptions;
using ExpenditureRecorder.Model;
using ExpenditureRecorder.Services;
using NUnit.Framework;
using System.Collections.Generic;

namespace ExpenditureRecorder.Test
{
    public class CategoryServiceTest
    {
        private CategoryService _categoryService;

        [SetUp]
        public void Setup()
        {
            _categoryService = new CategoryService();
        }

        [Test]
        public void CreateCategory()
        {
            Category category = _categoryService.Create("category1");
            Assert.AreEqual("category1", category.Name);
        }

        [Test]
        public void CreateNullCategory()
        {
            Assert.Throws<CategoryNameCannotBeEmptyOrNull>(() => _categoryService.Create(null));
        }

        [Test]
        public void CreateTakenCategoryName_ShouldThrowException()
        {
            _categoryService.Create("category1");
            Assert.Throws<CategoryNameInUsedException>(() => _categoryService.Create("category1"));
        }

        [Test]
        public void GetAllCategories()
        {
            List<Category> categories = _categoryService.GetAll();
            Assert.AreEqual(0, categories.Count);
        }

        [Test]
        public void AddAndGetAllCategories()
        {
            _categoryService.Create("category1");
            List<Category> categories = _categoryService.GetAll();
            Assert.AreEqual(1, categories.Count);
            Assert.AreEqual("category1", categories[0].Name);
        }

        //[Test]
        //public void UpdateCategoryNameById()
        //{
        //    Category category = _categoryService.Create("category1");
        //    category
        //}
    }
}