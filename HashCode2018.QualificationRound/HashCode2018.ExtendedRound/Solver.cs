using HashCode2018.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HashCode2018.ExtendedRound
{
    public class Solver : IProblemSolver
    {
        private Action<string> _writeLog;
        private Action<object> _iterationCallback;

        public void SetIterationCallback(Action<object> callback)
        {
            _iterationCallback = callback;
        }

        public void SetLogOutput(Action<string> writeLogAction)
        {
            _writeLog = writeLogAction;
        }

        public OutputFile Solve(InputFile inputFile, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
