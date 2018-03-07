using System.Collections.Generic;

namespace HashCode2018.ExtendedRound.Models
{
    public class Vehicle
    {
        public Vehicle()
        {
            CurrentPosition = new Point(0, 0);
            CompletedRides = new List<Ride>();
        }

        public Point CurrentPosition { get; set; }
        public Ride CurrentRide { get; set; }
        public bool IsBusy { get; set; }
        public List<Ride> CompletedRides { get; set; }
        public int AwaitSteps { get; set; }
    }
}
