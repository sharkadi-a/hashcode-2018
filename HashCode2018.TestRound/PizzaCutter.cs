using System;
using System.Collections.Generic;

namespace HashCode2018.TestRound
{
    public sealed class PizzaCutter
    {
        private readonly Pizza _pizza;

        public PizzaCutter(Pizza pizza)
        {
            _pizza = pizza;
        }

        public IEnumerable<Slice> Cut(int minIngridientCount, int maxCellsPerSliceCount)
        {
            throw new NotImplementedException();
        }
    }
}