using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using HashCode2018.Core;

namespace HashCode2018.TestRound
{
    public sealed partial class PizzaCutter : IProblemSolver
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

	    private bool IsAlreadyCutted(SliceCell sliceCell)
	    {
		    return _cuttedOutPices[sliceCell.Row][sliceCell.Column];
	    }

	    // TODO
	    private void CutOut(Slice slice)
	    {
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
	            if (IsAlreadyCutted(cell))
		            continue;

	            var slice = CrawlForSlice(cell.Row, cell.Column, minIngridientCount, patterns);
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

	    public void SetIterationCallback<TData>(Action<TData> callback) where TData : class
	    {
			// TODO:
	    }

	    public void SetLogOutput(Action<string> writeLogAction)
	    {
			// TODO:
	    }

	    public OutputFile Solve(InputFile inputFile, CancellationToken cancellationToken)
	    {
		    // TODO:
		    throw new NotImplementedException();
	    }
    }
}