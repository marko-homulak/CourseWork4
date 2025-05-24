using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

namespace BeeBearGUI
{
    public class SimulationController
    {
        private readonly List<Bee> _bees = new List<Bee>();
        private Bear _bear;
        private HoneyPot _pot;
        private CancellationTokenSource _cts;

        private bool _isStopped;
        private bool _soundEnabled;

        public StatisticsCollector Statistics { get; private set; }

        public event Action<string> OnLog;
        public event Action OnHoneyAdded;
        public event Action OnPotEmptied;

        public event Action<int> OnQueueUpdate;

        public StatisticsCollector GetStatistics { get { return Statistics; } }

        public void StartSimulation(int beeCount, int capacity, int minTime, int maxTime, int bearEatTime, bool soundEnabled)
        {
            _cts = new CancellationTokenSource();
            Statistics = new StatisticsCollector();

            _isStopped = false;
            _soundEnabled = soundEnabled;

            Statistics.SetSimulationParameters(beeCount, capacity, minTime, maxTime);

            _pot = new HoneyPot(capacity, bearEatTime, Statistics, _cts.Token);
            _pot.OnLog += msg => OnLog?.Invoke(msg);
            _pot.OnHoneyAdded += () => OnHoneyAdded?.Invoke();
            _pot.OnPotEmptied += () => OnPotEmptied?.Invoke();
            _pot.OnBearWakeUp += () =>
            {
                if (_soundEnabled && !_isStopped)
                    SoundManager.StopBuzzing();
            };
            _pot.OnBearEatHoney += () =>
            {
                if (_soundEnabled && !_isStopped)
                    SoundManager.PlayWokeUp();
            };
            _pot.OnBearSleep += () =>
            {
                if (_soundEnabled && !_isStopped)
                    SoundManager.StartBuzzing();
            };
            _pot.OnQueueChanged += (queueSize) =>
            {
                OnQueueUpdate?.Invoke(queueSize);
            };

            if (_soundEnabled)
                SoundManager.Initialize(true);

            _bear = new Bear(_pot, _cts.Token, msg => OnLog?.Invoke(msg));
            _bear.Start();

            for (int i = 0; i < beeCount; i++)
            {
                var bee = new Bee(i + 1, _pot, minTime, maxTime, _cts.Token, msg => OnLog?.Invoke(msg));
                _bees.Add(bee);
                bee.Start();
            }

            if (_soundEnabled)
                SoundManager.StartBuzzing();

            OnLog?.Invoke("✅ Simulation started.");
        }

        public void StopSimulation()
        {
            _cts.Cancel();
            _isStopped = true;

            if (_soundEnabled)
            {
                SoundManager.StopBuzzing();
                SoundManager.Dispose();
            }

            OnLog?.Invoke("🛑 Simulation stopping...");

            Statistics.PrintSummary(msg =>
            {
                OnLog?.Invoke(msg); // for output to ListBox
            });

            // Save the result in JSON
            var result = BuildResult();
            SimulationResultManager.Save(result);
            OnLog?.Invoke("💾 Результат симуляції збережено.");
        }

        public bool IsStopped()
        {
            return _cts != null && _cts.IsCancellationRequested;
        }

        private SimulationResult BuildResult()
        {
            var result = new SimulationResult
            {
                Timestamp = DateTime.Now,
                BeeCount = Statistics._beeCount,
                PotCapacity = Statistics._potCapacity,
                MinCollectTime = Statistics._minTime,
                MaxCollectTime = Statistics._maxTime,
                BearEatCount = Statistics.BearEatsCount,
                PotFillTimes = Statistics.PotFillDurations.ToList(),
                TotalFillTime = Statistics._totalTime,
                Bees = Statistics.BeeHoneyCounts.Select(kvp => new BeeStats
                {
                    BeeId = kvp.Key,
                    Deliveries = kvp.Value,
                    MinTime = Statistics.BeeMinCollectionTime[kvp.Key],
                    MaxTime = Statistics.BeeMaxCollectionTime[kvp.Key],
                    AvgTime = Statistics.BeeTotalCollectionTime[kvp.Key].TotalMilliseconds / kvp.Value
                }).ToList()
            };

            return result;
        }

    }
}
