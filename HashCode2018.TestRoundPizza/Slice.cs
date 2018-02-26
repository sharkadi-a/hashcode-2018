using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HashCode2018.TestRound
{
    public class Slice: IEquatable<Slice>, IEnumerable<SliceCell>
    {
        private readonly Slice _parent;
        protected readonly char[][] Slices;
        private readonly int _rows;
        private readonly int _columns;

        public const char OutOfBound = '?';
        
        public int R0 { get; private set; }
        public int R1 { get; private set; }
        public int C0 { get; private set; }
        public int C1 { get; private set; }
        
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

        private Slice(Slice parent, int r0, int r1, int c0, int c1): this(r1 - r0 + 1, c1 - c0 + 1)
        {
            _parent = parent;
            R0 = r0;
            R1 = r1;
            C0 = c0;
            C1 = c1;
        }

        protected static Slice NewCut(Slice parent, int r0, int r1, int c0, int c1)
        {
            var slice = new Slice(parent, r0, r1, c0, c1);

            for (int i = 0; i < slice.Slices.Length; i++)
            {
                for (int j = 0; j < slice.Slices[i].Length; j++)
                {
                    slice.Slices[i][j] = parent.Peek(r0 + i, c0 + j);
                }
            }

            return slice;
        }

        protected char Peek(int row, int column)
        {
            if (row < 0 || row >= _rows || column < 0 || column >= _columns)
                return OutOfBound;
            return Slices[row][column];
        }

        public SliceCell PeekCell(int row, int column)
        {
            return new SliceCell(row, column, Peek(row, column));
        }

        public IEnumerator<SliceCell> GetEnumerator()
        {
            return new SliceCellEnumerator(this);
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
            return string.Format("{0} {1} {2} {3}", R0, C0, R1, C1);
        }

        public bool Intersect(Slice other)
        {
            return R1 <= other.C0 && other.R1 <= C0 && R0 <= other.C1 && other.R0 <= C1;
        }

        public bool Equals(Slice other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(_parent, other._parent) && R0 == other.R0 && R1 == other.R1 && C0 == other.C0 &&
                   C1 == other.C1 && Equals(Slices, other.Slices) && _rows == other._rows &&
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
                hashCode = (hashCode * 397) ^ R0;
                hashCode = (hashCode * 397) ^ R1;
                hashCode = (hashCode * 397) ^ C0;
                hashCode = (hashCode * 397) ^ C1;
                hashCode = (hashCode * 397) ^ (Slices != null ? Slices.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ _rows;
                hashCode = (hashCode * 397) ^ _columns;
                return hashCode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}