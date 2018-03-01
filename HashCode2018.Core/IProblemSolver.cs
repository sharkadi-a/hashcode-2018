using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HashCode2018.Core
{
    public interface IProblemSolver
    {
	    void SetIterationCallback(Action<object> callback);
        void SetLogOutput(Action<string> writeLogAction);
        OutputFile Solve(InputFile inputFile, CancellationToken cancellationToken);
    }
}
