using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode2018.QualificationRound
{
	public struct Point
	{
		public int x;
		public int y;

		public Point(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		
	}

	public static class PointGeometry
	{
		public static int Distance(this Point p1, Point p2)
		{
			return Math.Abs(p2.x - p1.x) + Math.Abs(p2.y - p1.y);
		}
	}

	public class Ride
	{
		public Point start;
		public Point stop;
		public int earlistStart;
		public int latestFinish;
		public bool IsBusy;
	}
}
