using ExpenditureRecorder.Data.Enums;

namespace ExpenditureRecorder.Data
{
    public class Budget
    {
        public decimal Amount { get; set; }
        public int AlertPercentage { get; set; }
        public BudgetTimeline Timeline { get; set; }

        public Budget(decimal amount, int alertPercentage, BudgetTimeline timeline)
        {
            Amount = amount;
            AlertPercentage = alertPercentage;
            Timeline = timeline;
        }
    }
}