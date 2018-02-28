using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode2018.Core
{
    public sealed class InputFile
    {
        public FileInfo FileInfo { get; private set; }

        public InputFile(FileInfo fileInfo)
        {
            FileInfo = fileInfo;
        }

        public static IEnumerable<InputFile> GetInputFiles(string directory)
        {
            return Directory
                .GetFiles(directory)
                .Where(f => f.EndsWith(".in"))
                .Select(f => new InputFile(new FileInfo(f)));
        }

        public IEnumerable<string> ReadStrings()
        {
            using (var fileStream = new FileStream(FileInfo.FullName, FileMode.Open))
            using (var sr = new StreamReader(fileStream, Encoding.ASCII))
            {
                while (!sr.EndOfStream)
                {
                    yield return sr.ReadLine();
                }
            }
        }

        public OutputFile GetOutputFile()
        {
            var filename = FileInfo.Name.Replace(FileInfo.Extension, String.Empty) + ".out";
            return new OutputFile(Path.Combine(FileInfo.DirectoryName, filename));
        }

        public override string ToString()
        {
            return FileInfo.Name;
        }
    }
}
