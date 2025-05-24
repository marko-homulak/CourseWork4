namespace BeeBearGUI
{
    public class SimulationFilterSet
    {
        public int PotCapacity { get; set; }
        public int MinTime { get; set; }
        public int MaxTime { get; set; }

        public override string ToString() => $"PotCapacity: {PotCapacity}, Min_t: {MinTime}, Max_t: {MaxTime}";
    }
}
