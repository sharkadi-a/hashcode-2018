using System.Collections.Generic;

namespace HashCode2018.ExtendedRound.Models
{
    public class InputModel
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public int Vechiles { get; set; }
        public int Riders { get; set; }
        public int Bonus { get; set; }
        public int Steps { get; set; }

        public readonly List<Ride> Rides = new List<Ride>();
    }
}
