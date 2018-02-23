using System;
using System.Text;

namespace HashCode2018.TestRound
{
    public class Slice: IEquatable<Slice>
    {
        private Slice _parent;
        private int _r0;
        private int _r1;
        private int _c0;
        private int _c1;

        protected readonly char[][] Slices;

        private readonly int _rows;
        private readonly int _columns;
        
        public const char OutOfBound = char.MinValue;
        
        public int Rows
        {
            get { return _rows; }
        }

        public int Columns
        {
            get { return _columns; }
        }

        
        protected Slice(int rows, int columns)
        {
            _rows = rows;
            _columns = columns;
            Slices = new char[_rows][];
            for (int i = 0; i < Slices.Length; i++)
            {
                Slices[i] = new char[_columns];
            }
        }

        protected static Slice NewCut(Slice parent, int r0, int r1, int c0, int c1)
        {
            var slice = new Slice(r1 - r0 + 1, c1 - c0 + 1)
            {
                _parent = parent,
                _r0 = r0,
                _r1 = r1,
                _c0 = c0,
                _c1 = c1,
            };

            for (int i = 0; i < slice.Slices.Length; i++)
            {
                for (int j = 0; j < slice.Slices[i].Length; j++)
                {
                    slice.Slices[i][j] = parent.Peek(r0 + i, c0 + j);
                }
            }

            return slice;
        }

        public char Peek(int row, int column)
        {
            if (row < 0 || row >= _rows || column < 0 || column >= _columns)
                return OutOfBound;
            return Slices[row][column];
        }
        
        public override string ToString()
        {
            var sb = new StringBuilder(_rows * _columns + (Environment.NewLine.Length * 2));
            foreach (char[] row in Slices)
            {
                foreach (char column in row)
                {
                    sb.Append(column);
                }

                sb.Append("\n");
            }

            return sb.ToString();
        }

        public string GetNumbers()
        {
            return string.Format("{0} {1} {2} {3}", _r0, _c0, _r1, _c1);
        }

        public bool Intersect(Slice other)
        {
            return _r1 <= other._c0 && other._r1 <= _c0 && _r0 <= other._c1 && other._r0 <= _c1;
        }

        public bool Equals(Slice other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(_parent, other._parent) && _r0 == other._r0 && _r1 == other._r1 && _c0 == other._c0 &&
                   _c1 == other._c1 && Equals(Slices, other.Slices) && _rows == other._rows &&
                   _columns == other._columns;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Slice) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_parent != null ? _parent.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ _r0;
                hashCode = (hashCode * 397) ^ _r1;
                hashCode = (hashCode * 397) ^ _c0;
                hashCode = (hashCode * 397) ^ _c1;
                hashCode = (hashCode * 397) ^ (Slices != null ? Slices.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ _rows;
                hashCode = (hashCode * 397) ^ _columns;
                return hashCode;
            }
        }
    }
}