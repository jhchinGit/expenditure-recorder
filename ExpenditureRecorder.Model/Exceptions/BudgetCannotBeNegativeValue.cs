using System;

namespace ExpenditureRecorder.Data.Exceptions
{
    public class BudgetCannotBeNegativeValue : Exception
    {
        private const string DEFAULT_MESSAGE = "Budget cannot be negative amount.";

        public BudgetCannotBeNegativeValue() : base(DEFAULT_MESSAGE)
        {
        }
    }
}