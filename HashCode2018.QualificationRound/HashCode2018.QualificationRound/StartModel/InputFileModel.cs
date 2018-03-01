﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode2018.QualificationRound
{
	class InputFileModel
	{
		public int Rows { get; set; }
		public int Columns { get; set; }
		public int Vechiles { get; set; }
		public int Riders { get; set; }
		public int Bonus { get; set; }
		public int Steps { get; set; }

		public List<Ride> Rides = new List<Ride>();
		
	}
}
