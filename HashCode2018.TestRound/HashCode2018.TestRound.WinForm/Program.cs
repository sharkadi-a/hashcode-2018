using System;
using System.Windows.Forms;
using HashCode2018.TestRound.WinForm.Properties;

namespace HashCode2018.TestRound.WinForm
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Settings.Default.Reload();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
			Settings.Default.Save();
		}
	}
}
