using System.Collections.Generic;

namespace HashCode2018.TestRound.NetFrameWork
{
    public sealed class Pizza: Slice
    {
        public Pizza(int rows, int columns) : base(rows, columns)
        {
        }

        public void Fill(IEnumerable<string> stringData)
        {
            int i = 0;
            foreach (var str in stringData)
            {
                for (var j = 0; j < Cells[i].Length; j++)
                    Cells[i][j] = str[j];
                i++;
            }
        }

        public Slice Cut(int r0, int r1, int c0, int c1)
        {
            return NewCut(this, r0, r1, c0, c1);
        }
    }
}