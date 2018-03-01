﻿using System;
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
		            Run(car);
	            }
               
            }
        }

	    private void Planning(Machine car, int step)
	    {
		    var rides = _context.Model.Rides;
		    var minPrice = double.MaxValue;
			foreach (var ride in rides.Where(x=> !x.IsBusy))
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
			    }
		    }
	    }

	    private void Run(Machine car)
        {

        }
    }
}
