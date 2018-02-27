using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode2018.QualificationRound.Core
{
    public sealed class OutputFile: IDisposable
    {
        public FileInfo FileInfo { get; private set; }
        private readonly Lazy<StreamWriter> _sw;

        public OutputFile(string filename)
        {
            FileInfo = new FileInfo(filename);
            _sw = new Lazy<StreamWriter>(() =>
            {
                var streamWriter = new StreamWriter(FileInfo.OpenWrite(), Encoding.ASCII);
                streamWriter.NewLine = "\n";
                return streamWriter;
            });
        }

        public void AppendLine(string value)
        {
            _sw.Value.WriteLine(value);
        }

        public void AppendLineNumbers(IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
            {
                _sw.Value.Write(number);
                _sw.Value.Write(' ');
            }
            _sw.Value.Write(_sw.Value.NewLine);
        }

        public void Dispose()
        {
            if (_sw.IsValueCreated) _sw.Value.Dispose();
        }

        public override string ToString()
        {
            return FileInfo.Name;
        }
    }
}
