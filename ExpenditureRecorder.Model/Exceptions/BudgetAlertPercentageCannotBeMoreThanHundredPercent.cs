using System;

namespace ExpenditureRecorder.Data.Exceptions
{
    public class BudgetAlertPercentageCannotBeMoreThanHundredPercent : Exception
    {
        private const string DEFAULT_MESSAGE = "Budget alert percentage cannot be more than hundred.";

        public BudgetAlertPercentageCannotBeMoreThanHundredPercent() : base(DEFAULT_MESSAGE)
        {
        }
    }
}