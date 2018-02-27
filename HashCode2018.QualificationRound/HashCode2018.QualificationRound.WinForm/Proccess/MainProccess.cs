using System;
using System.Threading;
using System.Threading.Tasks;

namespace HashCode2018.QualificationRound.WinForm.Proccess
{
	class MainProccess
	{
		public async Task Start(string[] lines, CancellationToken cancelToken)
		{

			foreach (var line in lines)
			{
				await Task.Delay(1000, cancelToken);
				MessageWrite(line);
			}
			while (!cancelToken.IsCancellationRequested)
			{
				MessageWrite("Hello");
				await Task.Delay(3000, cancelToken);
				MessageWrite("Hello2");
				ViewReady(new View());
			}
		}

		public Action<string> MessageWrite;
		public Action<View> ViewReady;
	}
}
