using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode2018.QualificationRound.Core
{
    public class InputFile
    {
		public FileInfo FileInfo { get; private set; }

	    public IEnumerable<string> ReadStrings()
	    {
		    File.ReadAllLines(FileInfo.FullName);
	    }
    }
}
