using System;

namespace ExpenditureRecorder.Data.Exceptions
{
    public class CategoryNameCannotBeEmptyOrNull : Exception
    {
        private const string DEFAULT_MESSAGE = "Category name cannot be empty or null.";

        public CategoryNameCannotBeEmptyOrNull() : base(DEFAULT_MESSAGE)
        {
        }
    }
}