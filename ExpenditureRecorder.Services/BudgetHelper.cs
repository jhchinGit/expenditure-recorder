using ExpenditureRecorder.Data;
using ExpenditureRecorder.Data.Enums;
using ExpenditureRecorder.Data.Exceptions;

namespace ExpenditureRecorder.Services
{
    public static class BudgetHelper
    {
        public static Budget Generate(decimal budget)
        {
            return Generate(budget, 100, BudgetTimeline.Monthly);
        }

        public static Budget Generate(decimal budget, int alertPercentage)
        {
            return Generate(budget, alertPercentage, BudgetTimeline.Monthly);
        }

        public static Budget Generate(decimal budget, BudgetTimeline timeline)
        {
            return Generate(budget, 100, timeline);
        }

        public static Budget Generate(decimal budgetAmount, int alertPercentage, BudgetTimeline timeline)
        {
            var budget = new Budget(budgetAmount, alertPercentage, timeline);
            Validate(budget);
            return budget;
        }

        public static void Validate(Budget budget)
        {
            if (budget.Amount < 0)
                throw new BudgetCannotBeNegativeValue();

            if (budget.AlertPercentage > 100)
            {
                throw new BudgetAlertPercentageCannotBeMoreThanHundredPercent();
            }
            else if (budget.AlertPercentage < 0)
            {
                throw new BudgetAlertPercentageCannotBeNegativeValue();
            }
        }
    }
}