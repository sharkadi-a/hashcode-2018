using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HashCode2018.TestRound
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Test();
                return;
            }
            
            Run(args.Select(arg => new FileInfo(arg)));
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
            pizza.Fill(pizzaData);

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

        private static void Run(IEnumerable<FileInfo> fileInfos)
        {
            foreach (var fileInfo in fileInfos)
            {
                if (!fileInfo.Exists) throw new FileNotFoundException("Input file not found", fileInfo.FullName);

                var lines = File.ReadAllLines(fileInfo.FullName);
                var parameters = lines[0].Split(' ');
                var rows = int.Parse(parameters[0]);
                var columns = int.Parse(parameters[1]);
                var minIngridients = int.Parse(parameters[2]);
                var maxCellsPerSlice = int.Parse(parameters[3]);
                
                var pizza = new Pizza(rows, columns);
                pizza.Fill(lines.Skip(1));
                
                var pizzaCutter = new PizzaCutter(pizza);
                var slices = pizzaCutter.Cut(minIngridients, maxCellsPerSlice).ToArray();

                var output = new StringBuilder(slices.Length * 5);
                output.AppendFormat("{0}\n", slices.Length);
                foreach (var slice in slices)
                    output.AppendFormat("{0}\n", slice.GetNumbers());

                var outputDirectory = fileInfo.DirectoryName;
                var outputFilename = fileInfo.Name.Replace(fileInfo.Extension, string.Empty) + ".out";
                var outputFullname = Path.Combine(outputDirectory, outputFilename);
                File.WriteAllText(outputFullname, output.ToString());
            }
        }
    }
}