using System;
using System.Collections.Generic;
using System.Threading;
using HashCode2018.Core;

namespace HashCode2018.TestRound.NetFrameWork
{
    internal class Program
    {
	    private static readonly CancellationTokenSource CancellationTokenSource = new CancellationTokenSource();

        public static void Main(string[] args)
        {
            //if (args.Length == 0)
            //{
            //    Test();
            //    return;
            //}

	        IProblemSolver problemSolver = new PizzaCutter();
			problemSolver.SetLogOutput(Console.WriteLine);
			problemSolver.SetIterationCallback<char[][]>(c => Console.WriteLine(c));

			Run(InputFile.GetInputFiles(Helpers.GetWorkingDirectoryInfo().FullName), problemSolver);
	        Console.ReadLine();
        }

        private static void Test()
        {
            var pizzaData = new[]
            {
                "TTTTT",
                "TMMMT",
                "TTTTT"
            };
            
            var pizza = new Pizza(3, 5);
            pizza.Fill( pizzaData );

            Console.WriteLine(pizza);
            Console.WriteLine(pizza.PeekCell(2, 60));

            var slice = pizza.Cut(1, 1, 1, 3);
            Console.WriteLine("slice:");
            Console.WriteLine(slice);
            
            var slice2 = pizza.Cut(0, 1, 1, 3);
            Console.WriteLine("slice2:");
            Console.WriteLine(slice2);

            var slice3 = pizza.Cut(2, 2, 0, 5);
            Console.WriteLine("slice3:");
            Console.WriteLine(slice3);
            
            Console.WriteLine("slice intersect slice2:");
            Console.WriteLine(slice.Intersect(slice2));

            Console.WriteLine("slice2 intersect slice3:");
            Console.WriteLine(slice2.Intersect(slice3));
            
            Console.Read();
        }

        private static void Run(IEnumerable<InputFile> inputFiles, IProblemSolver problemSolver)
        {
            foreach (var inputFile in inputFiles)
            {
	            using (var outputFile = problemSolver.Solve(inputFile, CancellationTokenSource.Token))
	            {
					Console.WriteLine($"File {inputFile} solved.");
	            }
            }
        }
    }
}