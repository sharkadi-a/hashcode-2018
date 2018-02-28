using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using HashCode2018.Core;
using HashCode2018.TestRound.NetFrameWork.Patterns;

namespace HashCode2018.TestRound.NetFrameWork
{
    public sealed class PizzaCutter : IProblemSolver
    {
        private Pizza _pizza;
        private bool[][] _cuttedOutPices;
	    private Action<View> _callback;
	    private Action<string> _writeLog;

		void InitPizza()
        {
            _cuttedOutPices = new bool[_pizza.Rows][];
            for (var index = 0; index < _cuttedOutPices.Length; index++)
                _cuttedOutPices[index] = new bool[_pizza.Columns];
        }

	    private bool IsAlreadyCutted(SliceCell sliceCell)
	    {
		    return _cuttedOutPices[sliceCell.Row][sliceCell.Column];
	    }

	    private Slice CutOut(int startRow, int startColumn, Rectangle rectangle)
	    {
		    foreach (var offset in rectangle.CellsOffsets)
		    {
			    _cuttedOutPices[startRow + offset.y][startColumn + offset.x] = true;
		    }

		    return _pizza.Cut(startRow, startRow + rectangle.Heigth, startColumn, startColumn + rectangle.Width);
	    }

        private Slice CrawlForSlice(int startRow, int startColumn, int minIngridientCount, IList<Rectangle> rectangles)
        {
	        foreach (var rectangle in rectangles)
	        {
		        int mushrooms = 0, tomatoes = 0;
		        foreach (var offset in rectangle.CellsOffsets)
		        {
			        var currentRow = startRow + offset.y;
			        var currentColumn = startColumn + offset.x;

					var lookup = _pizza.PeekCell(currentRow, currentColumn);
			        if (lookup.Ingridient == Slice.OutOfBound || _cuttedOutPices[currentRow][currentColumn]) break;
			        if (lookup.Ingridient == 'T') tomatoes++;
			        if (lookup.Ingridient == 'M') mushrooms++;
		        }
		        if (mushrooms >= minIngridientCount && tomatoes >= minIngridientCount)
		        {
			        return CutOut(startRow, startColumn, rectangle);
		        }
			}

	        return null;
        }
		
        private IEnumerable<Slice> CutPizza(int minIngridientCount, int maxCellsPerSliceCount)
        {
	        var patternProccessor = new PatternProccesor();
	        var patterns = patternProccessor.GetPatterns(minIngridientCount, maxCellsPerSliceCount).ToList();

			foreach (var cell in _pizza)
            {
	            if (IsAlreadyCutted(cell))
		            continue;

	            var slice = CrawlForSlice(cell.Row, cell.Column, minIngridientCount, patterns);
                if (slice != null)
                {
	                _callback?.Invoke(new View(_pizza, _cuttedOutPices, slice));
	                yield return slice;
                }
            }
        }

	    private IEnumerable<Slice> Cut(int minIngridientCount, int maxCellsPerSliceCount)
        {
            return CutPizza(minIngridientCount, maxCellsPerSliceCount);
        }

	    public void SetIterationCallback<TData>(Action<TData> callback) where TData : class
	    {
		    if (typeof(TData) != typeof(View)) throw new Exception();
		    _callback = c => callback(c as TData);
	    }

	    public void SetLogOutput(Action<string> writeLogAction)
	    {
		    _writeLog = writeLogAction;
	    }

	    public OutputFile Solve(InputFile inputFile, CancellationToken cancellationToken)
	    {
		    var outputFile = inputFile.GetOutputFile();
		    int lineCount = 0, minIngridients = 0, maxCellsPerSlice = 0;
		    var dataLines = new List<string>();
			
			foreach (var inputLine in inputFile.ReadStrings())
		    {
			    if (lineCount == 0)
			    {
				    var parameters = inputLine.Split(' ');
				    var rows = int.Parse(parameters[0]);
				    var columns = int.Parse(parameters[1]);
				    minIngridients = int.Parse(parameters[2]);
				    maxCellsPerSlice = int.Parse(parameters[3]);

				    _pizza = new Pizza(rows, columns);
					InitPizza();
				}
			    else
			    {
					dataLines.Add(inputLine);
			    }
			    lineCount++;
		    }

			_pizza.Fill(dataLines);

		    var solution = Cut(minIngridients, maxCellsPerSlice).ToArray();
			outputFile.AppendLineNumbers(solution.Length);
		    foreach (var slice in solution)
		    {
			    outputFile.AppendLineNumbers(slice.R0, slice.R1, slice.C0, slice.C1);
		    }

		    return outputFile;
	    }
    }
}