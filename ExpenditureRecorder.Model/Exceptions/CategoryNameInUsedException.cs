using System;

namespace ExpenditureRecorder.Data.Exceptions
{
    public class CategoryNameInUsedException : Exception
    {
        private const string DEFAULT_MESSAGE = "Category name has already been taken.";

        public CategoryNameInUsedException() : base(DEFAULT_MESSAGE)
        {
        }
    }
}