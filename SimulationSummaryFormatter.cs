using System;
using System.Linq;

namespace BeeBearGUI
{
    public static class SimulationSummaryFormatter
    {
        public static void FormatFromResult(SimulationResult result, Action<string> log)
        {
            log($"\n📊 === STATISTICS for {result.Timestamp:yyyy-MM-dd HH:mm:ss} ===");
            log($"🐝 Bees: {result.BeeCount}, 🍯 Pot: {result.PotCapacity}, ⏱ Min: {result.MinCollectTime} ms, Max: {result.MaxCollectTime} ms");
            log($"🐻 Bear ate: {result.BearEatCount} times.");

            for (int i = 0; i < result.PotFillTimes.Count; i++)
            {
                log($"Cycle {i + 1} fill time: {result.PotFillTimes[i].TotalMilliseconds:F0} ms");
            }

            double avg = result.PotFillTimes.Count > 0
                ? result.PotFillTimes.Average(t => t.TotalMilliseconds)
                : 0;

            log($"Average fill time: {avg:F0} ms");
            log($"Total time for all cycles: {result.TotalFillTime:F0} ms");

            foreach (var bee in result.Bees.OrderBy(b => b.BeeId))
            {
                log($"\n🐝 Bee {bee.BeeId}:");
                log($"  - Deliveries: {bee.Deliveries}");
                log($"  - Min: {bee.MinTime} ms, Max: {bee.MaxTime} ms, Avg: {bee.AvgTime:F0} ms");
            }

            log("✅ End of stats.\n");
        }

        public static void FormatFromCollector(StatisticsCollector stats, Action<string> log)
        {
            lock (stats._lock)
            {
                log("\n📊 === SIMULATION PARAMETERS ===");
                log($"Bees:             {stats._beeCount}");
                log($"Pot capacity:     {stats._potCapacity}");
                log($"Min collect time: {stats._minTime} ms");
                log($"Max collect time: {stats._maxTime} ms");

                log("\n📊 === STATISTICS ===");
                log($"🐻 Bear ate {stats.BearEatsCount} times.");

                for (int i = 0; i < stats.PotFillDurations.Count; i++)
                {
                    log($"Cycle {i + 1} fill time: {stats.PotFillDurations[i].TotalMilliseconds:F0} ms");
                }

                if (stats.PotFillDurations.Count > 0)
                {
                    var avgFill = new TimeSpan((long)stats.PotFillDurations.Average(d => d.Ticks));
                    var totalFill = new TimeSpan(stats.PotFillDurations.Sum(d => d.Ticks));
                    log($"Average fill time: {avgFill.TotalMilliseconds:F0} ms");
                    log($"Total time for all cycles: {totalFill.TotalMilliseconds:F0} ms");
                }

                foreach (var kvp in stats.BeeHoneyCounts)
                {
                    int id = kvp.Key;
                    int count = kvp.Value;
                    var totalTime = stats.BeeTotalCollectionTime[id];
                    double avgTime = count > 0 ? totalTime.TotalMilliseconds / count : 0;

                    log($"\n🐝 Bee {id}:");
                    log($"  - Deliveries: {count}");

                    if (stats.BeeMinCollectionTime.TryGetValue(id, out int min))
                        log($"  - Min collection time: {min} ms");

                    if (stats.BeeMaxCollectionTime.TryGetValue(id, out int max))
                        log($"  - Max collection time: {max} ms");

                    log($"  - Avg collection time: {avgTime:F0} ms");
                }

                log("✅ End of stats.\n\n");
            }
        }

    }
}
