using ExpenditureRecorder.Data.Enums;

namespace ExpenditureRecorder.Data
{
    public class Budget
    {
        public decimal Amount { get; set; }
        public int AlertPercentage { get; set; }
        public BudgetTimeline BudgetTimeline { get; set; }
    }
}