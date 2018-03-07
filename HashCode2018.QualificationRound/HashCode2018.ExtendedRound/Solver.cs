using HashCode2018.Core;
using HashCode2018.ExtendedRound.Models;
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
            var outputFile = inputFile.GetOutputFile();
            int c = 0;
            var model = new InputModel();
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
                        OrdinalNumber = numberRide++,
                        StartPosition = new Point(input.Item2, input.Item1),
                        FinalPosition= new Point(input.Item4, input.Item3),
                        EarliestStart = input.Item5,
                        LatestFinish = input.Item6
                    });
                }
                c++;
            }

            var machines = new List<Vehicle>();
            for (var i = 0; i < model.Vechiles; i++)
            {
                machines.Add(new Vehicle());
            }

            throw new NotImplementedException();
        }
    }
}
