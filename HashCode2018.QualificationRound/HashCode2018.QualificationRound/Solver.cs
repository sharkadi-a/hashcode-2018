using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashCode2018.QualificationRound.RidePriceProcess;

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
            for (int step = 0; step < _context.Model.Steps; step++)
            {

	            foreach (var car in _context.Machines)
	            {
		            if (!car.IsBusy)
		            {
			            Planning(car, step);
					}
		            Run(car, step);
	            }
               
            }
        }

	    private void CalculateAwaitSteps(Machine car)
	    {

	    }

	    private void Planning(Machine car, int step)
	    {
		    var rides = _context.Model.Rides;
		    var minPrice = double.MaxValue;
			foreach (var ride in rides)
		    {
			    bool failed = true;
			   
			    var price = ProccessorPriceRide.Proccess(ride, step, car.currentPos, _context.Model.Steps, _context.Model.Bonus, out failed);
			    if (failed)
			    {
					continue;
			    }
			    if (price < minPrice)
			    {
				    minPrice = price;
				    car.CurrentRide = ride;
				    CalculateAwaitSteps(car);
			    }
		    }

			if (car.CurrentRide != null)
				_context.Model.Rides.Remove(car.CurrentRide);
	    }

	    public void Run(Machine car, int step)
	    {
		    if (!_context.Model.Rides.Any()) return;
		    if (car.currentPos.Equals(car.CurrentRide.start) && car.CurrentRide.earlistStart > step) return;
		    if (car.AwaitSteps > 0)
		    {
			    car.AwaitSteps--;
				return;
		    }

		    car.currentPos = car.CurrentRide.stop;
		    car.IsBusy = false;
		    car.CurrentRide = null;
	    }
    }
}
