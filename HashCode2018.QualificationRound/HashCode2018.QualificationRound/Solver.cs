using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode2018.QualificationRound
{
    public  class Solver
    {
        private Machine[]_cars;

        public Solver(Machine[] cars)
        {
            _cars = cars;
        }

        public void Solve(int steps, int vehiclesNum)
        {
            for (int i = 0; i < steps; i++)
            {
                for(int j = 0; j < vehiclesNum; j++)
                {
                    Run(_cars[j]);
                }
            }
        }

        public  void Run(Machine car)
        {

        }
    }
}
