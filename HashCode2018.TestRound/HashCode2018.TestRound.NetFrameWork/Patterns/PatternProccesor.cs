﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace HashCode2018.TestRound.NetFrameWork.Patterns
{
    class PatternProccesor
    {
	    public IEnumerable<Rectangle> GetPatterns(int minIngridientCount, int maxCellsPerSliceCount)
	    {
		    var minCellsSize = minIngridientCount * 2;

		    var templateSized = new List<int>();
		    for (var i = minCellsSize; i <= maxCellsPerSliceCount; i++)
		    {
			    templateSized.Add(i);
		    }

		    var rectangles = new List<Rectangle>();
		    foreach (var size in templateSized)
		    {
			    ProccessSize(size, rectangles);
		    }



		    return rectangles.OrderBy(Rate);

	    }

	    private int Rate(Rectangle rec)
	    {
		    var size = rec.CellsOffsets.Length;

		    return Math.Min(size / rec.Width, size / rec.Heigth) + size;
	    }

	    private static void ProccessSize(int size, List<Rectangle> rectangles)
	    {
		    for (var i = 1; i < size; i++)
		    {
			    if (size % i == 0)
			    {
				    CreateRectangle(size, rectangles, i);
			    }
		    }
	    }

	    private static void CreateRectangle(int size, List<Rectangle> rectangles, int i)
	    {
		    var width = i;
		    var height = size / width;

		    var cells = new List<CellOffset>();
		    for (var x = 0; x < width; x++)
		    {
			    for (var y = 0; y < height; y++)
			    {
				    var newCell = new CellOffset(x, y);
				    cells.Add(newCell);
			    }
		    }

		    var readyCells = cells.OrderBy(x => x.x + x.y).ToArray();
		    var newRectangle = new Rectangle(height, width, readyCells);
		    rectangles.Add(newRectangle);
	    }
	}
}
