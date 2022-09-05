using System;

namespace ExpenditureRecorder.Data
{
    public class Recorder
    {
        public Budget Budget { get; set; }
        public DateTime StartDate { get; set; }

        public Recorder(Budget budget, DateTime startDate)
        {
            Budget = budget;
            StartDate = startDate;
        }
    }
}