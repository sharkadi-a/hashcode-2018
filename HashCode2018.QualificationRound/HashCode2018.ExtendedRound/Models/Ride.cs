namespace HashCode2018.ExtendedRound.Models
{
    public class Ride
    {
        public int OrdinalNumber { get; set; }
        public Point StartPosition { get; set; }
        public Point FinalPosition { get; set; }
        public int EarlistStart { get; set; }
        public int LatestFinish { get; set; }
        public bool IsBusy { get; set; }
    }
}
