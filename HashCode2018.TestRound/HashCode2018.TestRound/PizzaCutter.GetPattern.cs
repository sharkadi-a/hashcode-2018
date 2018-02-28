using System;
using System.Collections.Generic;
using System.Text;

namespace HashCode2018.TestRound
{
	public sealed partial class PizzaCutter
    {
	    // TODO
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
    }
}
