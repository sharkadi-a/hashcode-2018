﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HashCode2018.Core;

namespace HashCode2018.QualificationRound
{
    public sealed class TestProblemSolver : IProblemSolver
    {
        private Action<string> _writeLog;
	    private Action<dynamic> _iterationCallback;

        public void SetIterationCallback<TData>(Action<TData> callback) where TData : class
        {
	        _iterationCallback = o => callback(o);
        }

        public void SetLogOutput(Action<string> writeLogAction)
        {
            _writeLog = writeLogAction;
        }

	    public OutputFile Solve(InputFile inputFile, CancellationToken cancellationToken)
        {
	        var outputFile = inputFile.GetOutputFile();
	        foreach (var value in inputFile.ReadStrings())
	        {
		        _writeLog("Processing value " + value);
		        var ints = InputParser.Map4(value);
				outputFile.AppendLineNumbers(ints.Item1, ints.Item2, ints.Item3, ints.Item4);
	        }

	        return outputFile;
        }
    }
}