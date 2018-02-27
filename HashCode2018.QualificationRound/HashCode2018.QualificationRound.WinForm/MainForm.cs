﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

		readonly MainManager _manager = new MainManager();
		private delegate void UpdateTextBox(string message);
		private delegate void UpdatePanel(View view);
		private void MainForm_Load(object sender, EventArgs e)
		{
			_manager.MessageReady += TextUpdateEvent;
			_manager.ViewReady += PanelUpdateEvent;
			PathTBx.Text = Settings.Default.LastFilePath;
		}

		private void PanelUpdateEvent(object sender, View view)
		{
			ChartPanel.Invoke(new UpdatePanel(UpdatePanelMethod), view);
		}

		private void UpdatePanelMethod(View view)
		{
			var graph = ChartPanel.CreateGraphics();
			var drawer = new Drawer(graph);
			drawer.Start(view);
			
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
			var lines = File.ReadAllLines(PathTBx.Text);
			_manager.Start(lines);
		}

		private void StopBtn_Click(object sender, EventArgs e)
		{
			_manager.Stop();
		}
	}
}
