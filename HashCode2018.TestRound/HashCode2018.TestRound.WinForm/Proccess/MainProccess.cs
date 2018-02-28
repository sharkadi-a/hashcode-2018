using System.Threading;
using System.Threading.Tasks;
using HashCode2018.Core;

namespace HashCode2018.TestRound.WinForm.Proccess
{
	internal class MainProccess
	{
		public Task Start(IProblemSolver problemSolver, InputFile inputFile, CancellationToken cancelToken)
		{
			return Task.Run(() => problemSolver.Solve(inputFile, cancelToken).Dispose(), cancelToken);
		}
	}
}
