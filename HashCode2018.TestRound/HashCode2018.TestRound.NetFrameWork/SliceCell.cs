﻿namespace HashCode2018.TestRound.NetFrameWork
{
    public struct SliceCell
    {
        private readonly int _row;
        private readonly int _column;
        private readonly char _ingridient;

		public SliceCell(int row, int column, char ingridient)
        {
            _row = row;
            _column = column;
            _ingridient = ingridient;
        }

        public int Row
        {
            get { return _row; }
        }

        public int Column
        {
            get { return _column; }
        }

        public char Ingridient
        {
            get { return _ingridient; }
        }

        public override string ToString()
        {
            return string.Format("{0}({1};{2})", _ingridient, _row, _column);
        }
    }
}