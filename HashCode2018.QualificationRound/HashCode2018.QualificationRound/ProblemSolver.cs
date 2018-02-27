using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashCode2018.QualificationRound.Core;

namespace HashCode2018.QualificationRound
{
    public sealed class ProblemSolver : IProblemSolver
    {
        private Action<string> _writeLog;

        public void SetIterationCallback<TData>(Action<TData> callback)
        {
            throw new NotImplementedException();
        }

        public void SetLogOutput(Action<string> writeLogAction)
        {
            _writeLog = writeLogAction;
        }

        public OutputFile Solve(InputFile inputFile)
        {
            throw new NotImplementedException();
        }
    }
}
