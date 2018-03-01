using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HashCode2018.Core;
using HashCode2018.QualificationRound.WinForm.Drawing;
using HashCode2018.QualificationRound.WinForm.Properties;

namespace HashCode2018.QualificationRound.WinForm
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private readonly MainManager _manager = new MainManager(new MachineProblemSolver());
		private Drawer _drawer;

		private delegate void UpdateTextBox(string message);
		private delegate void UpdatePanel(View view);
		private void MainForm_Load(object sender, EventArgs e)
		{
			_manager.MessageReady += TextUpdateEvent;
			_manager.ViewReady += PanelUpdateEvent;
			PathTBx.Text = Settings.Default.LastFilePath;
			DoubleBuffered = true;
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
			ResultTBx.Clear();
			_manager.Start(inputFile);
		}

		private void StopBtn_Click(object sender, EventArgs e)
		{
			_manager.Stop();
		}

		private void ChartPanel_Resize(object sender, EventArgs e)
		{
			var graph = ChartPanel.CreateGraphics();
			_drawer.Redraw(graph);
		}
	}
}
