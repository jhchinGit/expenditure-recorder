using System;

namespace ExpenditureRecorder.Data.Exceptions
{
    public class CategoryNotFoundException : Exception
    {
        private const string DEFAULT_MESSAGE = "Category cannot be found.";

        public CategoryNotFoundException() : base(DEFAULT_MESSAGE)
        {
        }
    }
}