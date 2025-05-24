using System;
using System.Threading;

namespace BeeBearGUI
{
    public class Bee
    {
        private readonly int _id;
        private readonly HoneyPot _pot;
        private readonly int _minDelay;
        private readonly int _maxDelay;
        private readonly CancellationToken _token;
        private readonly Random _random;
        private readonly Action<string> _logAction;

        private Thread _thread;

        public Bee(int id, HoneyPot pot, int minDelay, int maxDelay, CancellationToken token, Action<string> logAction)
        {
            _id = id;
            _pot = pot;
            _minDelay = minDelay;
            _maxDelay = maxDelay;
            _token = token;
            _random = new Random(Guid.NewGuid().GetHashCode());
            _logAction = logAction;
        }

        public void Start()
        {
            _thread = new Thread(() =>
            {
                while (!_token.IsCancellationRequested)
                {
                    int delay = _random.Next(_minDelay, _maxDelay + 1);
                    Thread.Sleep(delay);

                    if (_token.IsCancellationRequested) break;

                    _pot.AddHoney(_id, delay);
                }
                _logAction?.Invoke($"🐝 Bee {_id} thread is stopping.");
            });
            _thread.Start();
        }

    }
}
