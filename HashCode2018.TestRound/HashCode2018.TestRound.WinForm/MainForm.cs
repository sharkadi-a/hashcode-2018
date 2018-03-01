using System;
using System.IO;
using System.Windows.Forms;
using HashCode2018.Core;
using HashCode2018.TestRound.NetFrameWork;
using HashCode2018.TestRound.WinForm.Drawing;
using HashCode2018.TestRound.WinForm.Properties;
using View = HashCode2018.TestRound.NetFrameWork.View;

namespace HashCode2018.TestRound.WinForm
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private readonly MainManager _manager = new MainManager(new PizzaCutter());
		private Drawer _drawer;

		private delegate void UpdateTextBox(string message);
		private delegate void UpdatePanel(View view);
		private void MainForm_Load(object sender, EventArgs e)
		{
			_manager.MessageReady += TextUpdateEvent;
			_manager.ViewReady += PanelUpdateEvent;
			PathTBx.Text = Settings.Default.LastFilePath;
			this.DoubleBuffered = true;
			var graph = ChartPanel.CreateGraphics();
			_drawer = new Drawer(graph, ChartPanel.Width, ChartPanel.Height);
		}

		private void PanelUpdateEvent(object sender, View view)
		{
			ChartPanel.Invoke(new UpdatePanel(UpdatePanelMethod), view);
		}

		private void UpdatePanelMethod(View view)
		{
			
			
			
			_drawer.Start(view, UpdateTextBoxMethod);
			
		}

		private void TextUpdateEvent(object sender, string message)
		{
			ResultTBx.Invoke(new UpdateTextBox(UpdateTextBoxMethod), message);
		}

		private void UpdateTextBoxMethod(string message)
		{
			ResultTBx.Text += $"{message}\r\n";
		}

		private void BrowseBtn_Click(object sender, EventArgs e)
		{
			var dialog = new OpenFileDialog();
			var result = dialog.ShowDialog();
			if (result != DialogResult.OK) return;
			PathTBx.Text = dialog.FileName;
			Settings.Default.LastFilePath = dialog.FileName;
			Settings.Default.Save();

		}

		private void StartBtn_Click(object sender, EventArgs e)
		{
			var inputFile = new InputFile(new FileInfo(PathTBx.Text));
			_drawer.Clear(BackColor);
			_manager.Start(inputFile);

		}

		private void StopBtn_Click(object sender, EventArgs e)
		{
			_manager.Stop();
		}

		private void chkNoDraw_CheckedChanged(object sender, EventArgs e)
		{
			if (chkNoDraw.Checked)
			{

			}
		}

		private void ChartPanel_SizeChanged(object sender, EventArgs e)
		{
			_drawer.Redraw(ChartPanel.CreateGraphics());
		}
	}
}
