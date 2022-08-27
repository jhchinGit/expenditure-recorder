using ExpenditureRecorder.Model;
using ExpenditureRecorder.Services;
using NUnit.Framework;

namespace ExpenditureRecorder.Test
{
    public class CategoryServiceTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreateCategory()
        {
            Category category = CategoryService.Create("new category");
            Assert.AreEqual("new category", category.Name);
        }

        [Test]
        public void GetAllCategory()
        {
            var categories = CategoryService.GetAll();
            Assert.AreEqual(0, categories.Count);
        }
    }
}