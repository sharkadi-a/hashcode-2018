using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HashCode2018.Core;

namespace HashCode2018.QualificationRound.CLI
{
	internal class Program
    {
	    private static void Main(string[] args)
        {
            Console.WriteLine("FABULOUS CODERS Qualification Round Problem Solution");

            var files = args
                .Select(arg => new FileInfo(arg))
                .Where(fi => fi.Exists)
                .Select(fi => new InputFile(fi))
                .ToArray();
            if (files.Length == 0)
            {
                files = InputFile
                    .GetInputFiles(Helpers.GetWorkingDirectoryInfo().FullName)
                    .ToArray();
            }

            Console.WriteLine("Total input files: {0}", files.Length);
            Console.WriteLine("Starting at: {0}", DateTime.Now);

            var problemSolver = new TestProblemSolver();
            problemSolver.SetLogOutput(Console.WriteLine);

            var sw = Stopwatch.StartNew();
            foreach (var inputFile in files)
            {
                ProcessFile(inputFile, problemSolver);
            }
            Console.WriteLine("Total time elapsed: {0}", sw.Elapsed);
            sw.Stop();

            Console.WriteLine();
            Console.WriteLine("Hit any key to exit...");
            Console.Read();
        }

	    private static void ProcessFile(InputFile inputFile, IProblemSolver problemSolver)
        {
            Console.WriteLine("Solving {0}...", inputFile);
            var sw = Stopwatch.StartNew();
            using (var outputFile = problemSolver.Solve(inputFile, CancellationToken.None))
            {
                Console.WriteLine("Input file solved and saved into: {0}", outputFile);
                Console.WriteLine("Time elapsed for this input: {0}", sw.Elapsed);
            }
            sw.Stop();
        }
    }
}
