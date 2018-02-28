using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode2018.Core
{
    public static class Helpers
    {
        public static DirectoryInfo GetWorkingDirectoryInfo()
        {
            return new DirectoryInfo(Environment.CurrentDirectory);
        }
    }
}
