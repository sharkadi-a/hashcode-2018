using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace HashCode2018.TestRound
{
    public sealed class PizzaCutter
    {
        private readonly Pizza _pizza;
        private bool[][] _cuttedOutPices;

        public PizzaCutter(Pizza pizza)
        {
            _pizza = pizza;
            _cuttedOutPices = new bool[_pizza.Rows][];
            for (var index = 0; index < _cuttedOutPices.Length; index++)
                _cuttedOutPices[index] = new bool[_pizza.Columns];
        }

        private Slice CrawlForSlice(int startRow, int startColumn, int minIngridientCount, int maxCellsPerSliceCount)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<Slice> CutPizza(int minIngridientCount, int maxCellsPerSliceCount)
        {
            foreach (var cell in _pizza)
            {
                var slice = CrawlForSlice(cell.Row, cell.Column, minIngridientCount, maxCellsPerSliceCount);
                if (slice != null)
                {
                    yield return slice;
                }
            }
        }

        public IEnumerable<Slice> Cut(int minIngridientCount, int maxCellsPerSliceCount)
        {
            return CutPizza(minIngridientCount, maxCellsPerSliceCount);
        }
    }
}