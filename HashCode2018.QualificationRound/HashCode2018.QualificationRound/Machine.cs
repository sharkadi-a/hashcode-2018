using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode2018.QualificationRound
{
	public class Machine
	{
		public Point currentPos = new Point(0,0);
		public bool IsBusy;
		public Ride CurrentRide;
		public List<Ride> CompletedRides = new List<Ride>();
		public int AwaitSteps;
	}
}
