using System;
using System.Collections.Generic;

namespace HashCode2018.TestRoundPizza
{
    public sealed class PizzaCutter
    {
        private readonly Pizza _pizza;
        private readonly IRenderer _renderer;
        private bool[][] _cuttedOutPices;

        public PizzaCutter(Pizza pizza, IRenderer renderer)
        {
            _pizza = pizza;
            _renderer = renderer;
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
                    //_renderer.Render(???);
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