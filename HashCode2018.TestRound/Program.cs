using System;

namespace HashCode2018.TestRound
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var pizzaData = new string[]
            {
                "TTTTT",
                "TMMMT",
                "TTTTT"
            };
            
            var pizza = new Pizza(3, 5);
            pizza.Fill(pizzaData);

            Console.WriteLine(pizza);
            Console.WriteLine(pizza.Peek(2, 60));

            var slice = pizza.Cut(1, 1, 1, 3);
            Console.WriteLine(slice);
            var slice2 = pizza.Cut(0, 1, 1, 3);
            Console.WriteLine(slice2);
            
            Console.ReadKey();
        }
    }
}