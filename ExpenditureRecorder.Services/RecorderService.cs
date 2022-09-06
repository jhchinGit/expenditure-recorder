using ExpenditureRecorder.Data;
using System;
using System.Collections.Generic;

namespace ExpenditureRecorder.Services
{
    public class RecorderService
    {
        public List<Item> IncomeItems { get; private set; }
        public List<Item> ExpenseItems { get; private set; }

        public Budget Budget { get; private set; }

        private readonly DateTime _startDate = DateTime.Now.Date;

    }
}