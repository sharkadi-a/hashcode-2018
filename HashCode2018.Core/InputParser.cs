using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode2018.Core
{
    public static class InputParser
    {
        private static IEnumerable<int> Parse(string inputLine)
        {
            return inputLine.Split(' ').Select(int.Parse);
        }

        public static int[] MapMany(string inputLine)
        {
            return Parse(inputLine).ToArray();
        }

        public static int Map1(string inputLine)
        {
            return Parse(inputLine).First();
        }

        public static Tuple<int, int> Map2(string inputLine)
        {
            var parsed = Parse(inputLine).ToArray();
            return new Tuple<int, int>(parsed[0], parsed[1]);
        }
        public static Tuple<int, int, int> Map3(string inputLine)
        {
            var parsed = Parse(inputLine).ToArray();
            return new Tuple<int, int, int>(parsed[0], parsed[1], parsed[2]);
        }

        public static Tuple<int, int, int, int> Map4(string inputLine)
        {
            var parsed = Parse(inputLine).ToArray();
            return new Tuple<int, int, int, int>(parsed[0], parsed[1], parsed[2], parsed[3]);
        }

	    public static Tuple<int, int, int, int, int, int> Map6(string inputLine)
	    {
		    var parsed = Parse(inputLine).ToArray();
		    return new Tuple<int, int, int, int, int, int>(parsed[0], parsed[1], parsed[2], parsed[3], parsed[4], parsed[5]);
	    }
    }
}
