using ExpenditureRecorder.Data;

namespace ExpenditureRecorder.Services
{
    public class RecorderService
    {
        private readonly Recorder _recorder;

        public RecorderService()
        {
            _recorder = new Recorder();
        }
    }
}