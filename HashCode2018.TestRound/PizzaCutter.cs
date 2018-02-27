using System;
using System.Collections.Generic;
using System.Linq;

namespace HashCode2018.TestRound
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

        private Slice CrawlForSlice(int startRow, int startColumn, int minIngridientCount, IList<Rectangle> rectangles)
        {
			throw new Exception();
		}

        private IEnumerable<Slice> CutPizza(int minIngridientCount, int maxCellsPerSliceCount)
        {
	        var patterns = GetPatterns(minIngridientCount, maxCellsPerSliceCount).ToList();

			foreach (var cell in _pizza)
            {
	            if (cell.IsSliced)
	            {
					continue;
	            }

                var slice = CrawlForSlice(cell.Row, cell.Column, minIngridientCount, patterns);
                if (slice != null)
                {
                    //_renderer.Render(???);
                    yield return slice;
                }
            }
        }

	    private IEnumerable<Rectangle> GetPatterns(int minIngridientCount, int maxCellsPerSliceCount)
	    {
		    var minCellsSize = minIngridientCount * 2;

			var templateSized = new List<int>();
		    for (var i = minCellsSize; i < maxCellsPerSliceCount; i++)
		    {
			    if (i % 2 == 0)
			    {
				    templateSized.Add(i);

				}
		    }

			var rectangles = new List<Rectangle>();
			foreach (var size in templateSized)
		    {
			    
		    }

		    return rectangles;

	    }

	    public IEnumerable<Slice> Cut(int minIngridientCount, int maxCellsPerSliceCount)
        {
            return CutPizza(minIngridientCount, maxCellsPerSliceCount);
        }
    }
}