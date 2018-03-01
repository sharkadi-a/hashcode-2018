using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode2018.QualificationRound
{
    public class Solver
    {
        private Context _context;

        public Solver(Context context)
        {
            _context = context;
        }

        public void Solve()
        {
            for (int i = 0; i < _context.Model.Steps; i++)
            {
                for(int j = 0; j < _context.Model.Vechiles; j++)
                {
                    Run(_context.Machines[j]);
                }
            }
        }

        public  void Run(Machine car)
        {

        }
    }
}
