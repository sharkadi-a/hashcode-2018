using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HashCode2018.Core;
using HashCode2018.QualificationRound.WinForm.Drawing;

namespace HashCode2018.QualificationRound.WinForm.Proccess
{
	internal class MainProccess
	{
		public Task Start(IProblemSolver problemSolver, InputFile inputFile, CancellationToken cancelToken)
		{
			return Task.Run<OutputFile>(() => problemSolver.Solve(inputFile, cancelToken), cancelToken)
				.ContinueWith(t =>
				{
					MessageBox.Show($"Completed! Outputfile: {t.Result.FileInfo}", "Start", MessageBoxButtons.OK,
						MessageBoxIcon.Information);
					t.Result.Dispose();
					return t.Result;
				});
		}
	}
}
