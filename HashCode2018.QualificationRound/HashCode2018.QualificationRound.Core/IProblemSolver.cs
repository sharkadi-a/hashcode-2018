using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode2018.QualificationRound.Core
{
    public interface IProblemSolver
    {
        void SetIterationCallback<TData>(Action<TData> callback);
        void SetLogOutput(Action<string> writeLogAction);
        OutputFile Solve(InputFile inputFile);
    }
}
