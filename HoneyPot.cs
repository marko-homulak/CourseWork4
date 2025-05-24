using System;
using System.Collections.Concurrent;
using System.Threading;

namespace BeeBearGUI
{
    public class HoneyPot
    {
        private int _current = 0;
        private readonly int _capacity;
        private readonly int _bearEatTime;
        private readonly object _lock = new object();
        private readonly ConcurrentQueue<int> _beeQueue = new ConcurrentQueue<int>();
        private readonly StatisticsCollector _stats;
        private readonly CancellationToken _token;

        public event Action<string> OnLog;
        public event Action OnHoneyAdded;
        public event Action OnPotEmptied;

        public event Action OnBearWakeUp;
        public event Action OnBearEatHoney;
        public event Action OnBearSleep;

        public event Action<int> OnQueueChanged;

        public HoneyPot(int capacity, int bearEatTime, StatisticsCollector stats, CancellationToken token)
        {
            _capacity = capacity;
            _bearEatTime = bearEatTime;
            _stats = stats;
            _token = token;

            _stats.StartNewCycle();
        }

        public void AddHoney(int beeId, int delay)
        {
            lock (_lock)
            {
                _beeQueue.Enqueue(beeId);
                OnQueueChanged?.Invoke(_beeQueue.Count);
                OnLog?.Invoke($"🐝 Bee {beeId} queued to add honey.");

                while (_beeQueue.TryPeek(out int front) && front != beeId)
                {
                    Monitor.Wait(_lock);
                    if (_token.IsCancellationRequested) return;
                }

                if (_current < _capacity)
                {
                    _current++;
                    _stats.RecordHoneyAdded(beeId, delay);

                    OnLog?.Invoke($"🐝 Bee {beeId} added honey. Pot: {_current}/{_capacity}");
                    OnHoneyAdded?.Invoke();

                    if (_current == _capacity)
                    {
                        OnLog?.Invoke($"🐝 Bee {beeId} woke up the 🐻 bear!");
                        Monitor.PulseAll(_lock);
                    }
                }

                _beeQueue.TryDequeue(out _);
                OnQueueChanged?.Invoke(_beeQueue.Count);
                Monitor.PulseAll(_lock);
            }
        }

        public void WaitUntilFullAndEat()
        {
            lock (_lock)
            {
                while (_current < _capacity && !_token.IsCancellationRequested)
                {
                    Monitor.Wait(_lock);
                    if (_token.IsCancellationRequested) return;
                }

                if (_current >= _capacity)
                {
                    OnLog?.Invoke("🐻 Bear wakes up and eats all the honey! 🍯😋");

                    OnBearWakeUp?.Invoke();
                    OnBearEatHoney?.Invoke();

                    Thread.Sleep(_bearEatTime); // simulate eating

                    _current = 0;
                    _stats.RecordBearEat();
                    _stats.RecordPotFilled();

                    OnLog?.Invoke("🐻 Bear goes back to sleep... 💤");
                    OnBearSleep?.Invoke();
                    OnPotEmptied?.Invoke();          

                    Monitor.PulseAll(_lock);
                }
            }
        }

    }
}
