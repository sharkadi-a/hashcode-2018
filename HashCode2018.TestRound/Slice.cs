using System;
using System.Text;

namespace HashCode2018.TestRound
{
    public class Slice
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

        protected static Slice CutSlice(Slice parent, int r0, int r1, int c0, int c1)
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

                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}