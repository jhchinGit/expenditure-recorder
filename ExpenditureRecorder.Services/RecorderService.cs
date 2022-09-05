using ExpenditureRecorder.Data;
using ExpenditureRecorder.Data.Enums;
using System;

namespace ExpenditureRecorder.Services
{
    public class RecorderService
    {
        private readonly Recorder _recorder;

        public RecorderService(Budget budget)
        {
            _recorder = new Recorder(budget, DateTime.Now.Date);
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
            _recorder.Budget = new Budget(budget, alertPercentage, timeline);
        }
    }
}