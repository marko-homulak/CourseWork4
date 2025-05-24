using System;
using System.Collections.Generic;
using System.Linq;

namespace BeeBearGUI
{
    public class StatisticsCollector
    {
        public object _lock { get; private set; } = new object();

        private DateTime cycleStartTime = DateTime.Now;
        public int BearEatsCount { get; private set; } = 0;
        public List<TimeSpan> PotFillDurations { get; } = new List<TimeSpan>();
        public Dictionary<int, int> BeeHoneyCounts { get; } = new Dictionary<int, int>(); // total
        public Dictionary<int, TimeSpan> BeeTotalCollectionTime { get; } = new Dictionary<int, TimeSpan>();
        public Dictionary<int, int> BeeTotalDeliveries { get; } = new Dictionary<int, int>();
        public Dictionary<int, int> BeeMinCollectionTime { get; private set; } = new Dictionary<int, int>();
        public Dictionary<int, int> BeeMaxCollectionTime { get; private set; } = new Dictionary<int, int>();

        public int _beeCount { get; private set; }
        public int _potCapacity { get; private set; }
        public int _minTime { get; private set; }
        public int _maxTime { get; private set; }
        public double _totalTime { get; private set; }
        public void SetSimulationParameters(int beeCount, int potCapacity, int minTime, int maxTime)
        {
            _beeCount = beeCount;
            _potCapacity = potCapacity;
            _minTime = minTime;
            _maxTime = maxTime;
        }

        public void StartNewCycle()
        {
            lock (_lock)
            {
                cycleStartTime = DateTime.Now;
            }
        }

        public void RecordHoneyAdded(int beeId, int delay)
        {
            lock (_lock)
            {
                if (!BeeHoneyCounts.ContainsKey(beeId))
                    BeeHoneyCounts[beeId] = 0;
                BeeHoneyCounts[beeId]++;

                if (!BeeTotalDeliveries.ContainsKey(beeId))
                    BeeTotalDeliveries[beeId] = 0;
                BeeTotalDeliveries[beeId]++;

                if (!BeeTotalCollectionTime.ContainsKey(beeId))
                    BeeTotalCollectionTime[beeId] = TimeSpan.Zero;

                BeeTotalCollectionTime[beeId] += TimeSpan.FromMilliseconds(delay);

                // Min/Max logic
                if (!BeeMinCollectionTime.ContainsKey(beeId))
                {
                    BeeMinCollectionTime[beeId] = delay;
                    BeeMaxCollectionTime[beeId] = delay;
                }
                else
                {
                    if (delay < BeeMinCollectionTime[beeId]) BeeMinCollectionTime[beeId] = delay;
                    if (delay > BeeMaxCollectionTime[beeId]) BeeMaxCollectionTime[beeId] = delay;
                }
            }
        }

        public void RecordPotFilled()
        {
            lock (_lock)
            {
                PotFillDurations.Add(DateTime.Now - cycleStartTime);
                cycleStartTime = DateTime.Now; // for the next cycle
            }
        }

        public void RecordBearEat()
        {
            lock (_lock)
            {
                BearEatsCount++;
            }
        }

        public void PrintSummary(Action<string> logAction)
        {
            SimulationSummaryFormatter.FormatFromCollector(this, logAction);
        }

    }

}
