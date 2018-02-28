using System.Collections;
using System.Collections.Generic;

namespace HashCode2018.TestRound.NetFrameWork
{
    internal class SliceCellEnumerator: IEnumerator<SliceCell>
    {
        private readonly Slice _slice;
        private readonly int _startRow;
        private readonly int _startColumn;
        private int _currentRow;
        private int _currentColumn;

        public SliceCellEnumerator(Slice slice)
        {
            _slice = slice;
            _startRow = slice.R0;
            _startColumn = slice.C0;
            _currentRow = _startRow;
            _currentColumn = _startColumn;
        }
        
        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            var nextRow = _currentRow;
            var nextColumn = _currentColumn + 1;
            if (nextColumn > _slice.C1)
            {
                nextColumn = _startColumn;
                nextRow = _currentRow + 1;
                if (nextRow > _slice.R1)
                    return false;
            }

            _currentRow = nextRow;
            _currentColumn = nextColumn;
            Current = _slice.PeekCell(_currentRow, _currentColumn);
            return true;
        }

        public void Reset()
        {
            _currentColumn = _startColumn;
            _currentRow = _startRow;
        }

        public SliceCell Current { get; private set; }

        object IEnumerator.Current
        {
            get { return Current; }
        }
    }
}