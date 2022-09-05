using ExpenditureRecorder.Data.Enums;
using System;

namespace ExpenditureRecorder.Data
{
    public class Recorder
    {
        public Budget Budget { get; set; }
        public DateTime StartDate { get; set; }

        public Recorder()
        {
            StartDate = DateTime.Now.Date;
        }

        public void SetBudget(decimal budget)
        {
            SetBudget(budget, 100, BudgetTimeline.Monthly);
        }

        public void SetBudget(decimal budget, int alertPercentage)
        {
            SetBudget(budget, alertPercentage, BudgetTimeline.Monthly);
        }

        public void SetBudget(decimal budget, BudgetTimeline timeline)
        {
            SetBudget(budget, 100, timeline);
        }

        public void SetBudget(decimal budget, int alertPercentage, BudgetTimeline timeline)
        {

        }
    }
}