using System;
using System.Threading;
using System.Threading.Tasks;
using HashCode2018.Core;
using HashCode2018.QualificationRound.WinForm.Drawing;

namespace HashCode2018.QualificationRound.WinForm.Proccess
{
	internal class MainProccess
	{
		public Task Start(IProblemSolver problemSolver, InputFile inputFile, CancellationToken cancelToken)
		{
			return Task.Run(() => problemSolver.Solve(inputFile, cancelToken).Dispose(), cancelToken);
		}
	}
}
