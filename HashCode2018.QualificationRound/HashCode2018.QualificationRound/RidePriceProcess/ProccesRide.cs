using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode2018.QualificationRound.RidePriceProcess
{
	class ProccessorPriceRide
	{

		public static double Proccess(Ride ride, int currentStep, Point currentPos, int maxStep, int modelBonus,
			out bool failed)
		{
			var timeToRide = ride.start.Distance(ride.stop);
			var timeToStartGo = currentPos.Distance(ride.start);
			var maxRideTimeEnd = currentStep + timeToRide + timeToStartGo;

			if (maxRideTimeEnd > ride.latestFinish && maxRideTimeEnd > maxStep)
			{
				failed = true;
				return int.MaxValue;
			}

			var timeStartReached = currentStep + timeToStartGo;

			var timeIdle = ride.earlistStart - timeStartReached;
			var bonus = 0;
			if (timeStartReached <= ride.earlistStart)
			{
				bonus = modelBonus;
			}
			var price = timeIdle + timeToStartGo - bonus * 1.01;
			failed = false;
			return price;
		}
	}
}
