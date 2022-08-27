using ExpenditureRecorder.Model;
using System.Collections.Generic;

namespace ExpenditureRecorder.Services
{
    public class CategoryService
    {
        public static Category Create(string name)
        {
            return new Category(name);
        }

        public static List<Category> GetAll()
        {
            return new List<Category>();
        }
    }
}