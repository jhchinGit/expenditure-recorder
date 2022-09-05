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

        
    }
}