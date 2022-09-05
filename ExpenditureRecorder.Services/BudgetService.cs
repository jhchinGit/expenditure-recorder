using ExpenditureRecorder.Data;
using ExpenditureRecorder.Data.Enums;

namespace ExpenditureRecorder.Services
{
    public static class BudgetService
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

        public static Budget Generate(decimal budget, int alertPercentage, BudgetTimeline timeline)
        {
            return new Budget(budget, alertPercentage, timeline);
        }
    }
}