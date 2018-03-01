using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashCode2018.Core;

namespace HashCode2018.QualificationRound
{
	class Context
	{
		public InputFileModel Model { get; set; }
		public List<Machine> Machines { get; set; }
		public OutputFile OutputFile { get; set; }
	}
}
