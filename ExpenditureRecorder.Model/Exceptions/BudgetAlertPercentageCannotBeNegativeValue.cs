using System;

namespace ExpenditureRecorder.Data.Exceptions
{
    public class BudgetAlertPercentageCannotBeNegativeValue : Exception
    {
        private const string DEFAULT_MESSAGE = "Budget alert percentage cannot be negative value.";

        public BudgetAlertPercentageCannotBeNegativeValue() : base(DEFAULT_MESSAGE)
        {
        }
    }
}