using System.Collections.Generic;

namespace HashCode2018.ExtendedRound.Models
{
    public class Vehicle
    {
        public Point currentPos = new Point(0, 0);
        public bool IsBusy;
        public Ride CurrentRide;
        public List<Ride> CompletedRides = new List<Ride>();
        public int AwaitSteps;
    }
}
