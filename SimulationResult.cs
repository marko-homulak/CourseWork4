using System;
using System.Collections.Generic;

namespace BeeBearGUI
{
    public class SimulationResult
    {
        public DateTime Timestamp { get; set; }
        public int BeeCount { get; set; }
        public int PotCapacity { get; set; }
        public int MinCollectTime { get; set; }
        public int MaxCollectTime { get; set; }
        public int BearEatCount { get; set; }
        public double TotalFillTime { get; set; }
        public List<TimeSpan> PotFillTimes { get; set; } = new List<TimeSpan>();
        public List<BeeStats> Bees { get; set; } = new List<BeeStats>();
    }
}
