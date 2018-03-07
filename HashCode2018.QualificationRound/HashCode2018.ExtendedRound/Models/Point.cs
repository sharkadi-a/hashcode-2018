using System;

namespace HashCode2018.ExtendedRound.Models
{
    public class Point : IEquatable<Point>
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Point && Equals((Point)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 397) ^ Y;
            }
        }

        public bool Equals(Point obj)
        {
            return this.X == obj.X && this.Y == obj.Y;
        }
    }
}
