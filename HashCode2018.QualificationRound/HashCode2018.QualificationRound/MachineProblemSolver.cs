using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HashCode2018.Core;

namespace HashCode2018.QualificationRound
{
    public sealed class MachineProblemSolver : IProblemSolver
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

	    private void StartSolve(Context context)
	    {
			var solver = new Solver(context);
		    solver.Solve();
	    }

	    public OutputFile Solve(InputFile inputFile, CancellationToken cancellationToken)
        {
	        var outputFile = inputFile.GetOutputFile();
	        int c = 0;
	        var model = new InputFileModel();
	        var numberRide = 0;
	        foreach (var value in inputFile.ReadStrings())
	        {
		        var input = InputParser.Map6(value);
		        if (c == 0)
		        {
			        model.Rows = input.Item1;
			        model.Columns = input.Item2;
			        model.Vechiles = input.Item3;
			        model.Riders = input.Item4;
			        model.Bonus = input.Item5;
			        model.Steps = input.Item6;
		        }
		        else
		        {
			        model.Rides.Add(new Ride()
			        {
						Number = numberRide++,
						start = new Point() {x = input.Item2, y = input.Item1},
				        stop = new Point() {x = input.Item4, y = input.Item3},
				        earlistStart = input.Item5,
				        latestFinish = input.Item6
			        });
		        }
		        c++;
	        }

	        var machines = new List<Machine>();
			for (var i = 0; i < model.Vechiles; i++)
			{
				machines.Add(new Machine() {currentPos = new Point(0, 0), CurrentRide = null, IsBusy = false});
			}

	        var context = new Context()
	        {
		        Machines = machines,
		        Model = model,
		        OutputFile = outputFile
	        };

			StartSolve(context);

	        for (var i = 0; i < context.Machines.Count; i++)
	        {
		        var contextMachine = context.Machines[i];
		        List<int> outputNumbers = new List<int>();
				outputNumbers.Add(i);
				outputNumbers.AddRange(contextMachine.CompletedRides.Select(x => x.Number));
		        outputFile.AppendLineNumbers(outputNumbers.ToArray());
	        }

	        return outputFile;
        }
    }
}
