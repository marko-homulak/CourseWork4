using System;
using System.Threading;

namespace BeeBearGUI
{
    public class Bear
    {
        private readonly HoneyPot _pot;
        private readonly CancellationToken _token;
        private readonly Action<string> _logAction;

        private Thread _thread;

        public Bear(HoneyPot pot, CancellationToken token, Action<string> logAction)
        {
            _pot = pot;
            _token = token;
            _logAction = logAction;
        }

        public void Start()
        {
            _thread = new Thread(() =>
            {
                while (!_token.IsCancellationRequested)
                {
                    _pot.WaitUntilFullAndEat();
                }
                _logAction?.Invoke("🐻 Bear thread is stopping.");
            });
            _thread.Start();
        }

    }
}
