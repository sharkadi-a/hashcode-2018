namespace HashCode2018.QualificationRound.WinForm
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.StopBtn = new System.Windows.Forms.Button();
			this.PathTBx = new System.Windows.Forms.TextBox();
			this.BrowseBtn = new System.Windows.Forms.Button();
			this.StartBtn = new System.Windows.Forms.Button();
			this.ResultTBx = new System.Windows.Forms.TextBox();
			this.ChartPanel = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.ResultTBx, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.ChartPanel, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(941, 638);
			this.tableLayoutPanel1.TabIndex = 9;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.StopBtn);
			this.panel1.Controls.Add(this.PathTBx);
			this.panel1.Controls.Add(this.BrowseBtn);
			this.panel1.Controls.Add(this.StartBtn);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(394, 69);
			this.panel1.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 20;
			this.label2.Text = "Input file:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(-62, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 19;
			this.label1.Text = "Input file:";
			// 
			// StopBtn
			// 
			this.StopBtn.Location = new System.Drawing.Point(298, 34);
			this.StopBtn.Name = "StopBtn";
			this.StopBtn.Size = new System.Drawing.Size(75, 23);
			this.StopBtn.TabIndex = 18;
			this.StopBtn.Text = "S&top";
			this.StopBtn.UseVisualStyleBackColor = true;
			this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
			// 
			// PathTBx
			// 
			this.PathTBx.Location = new System.Drawing.Point(67, 8);
			this.PathTBx.Name = "PathTBx";
			this.PathTBx.Size = new System.Drawing.Size(306, 20);
			this.PathTBx.TabIndex = 15;
			this.PathTBx.Text = global::HashCode2018.QualificationRound.WinForm.Properties.Settings.Default.LastFilePath;
			// 
			// BrowseBtn
			// 
			this.BrowseBtn.Location = new System.Drawing.Point(136, 34);
			this.BrowseBtn.Name = "BrowseBtn";
			this.BrowseBtn.Size = new System.Drawing.Size(75, 23);
			this.BrowseBtn.TabIndex = 16;
			this.BrowseBtn.Text = "&Browse...";
			this.BrowseBtn.UseVisualStyleBackColor = true;
			this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
			// 
			// StartBtn
			// 
			this.StartBtn.Location = new System.Drawing.Point(217, 34);
			this.StartBtn.Name = "StartBtn";
			this.StartBtn.Size = new System.Drawing.Size(75, 23);
			this.StartBtn.TabIndex = 17;
			this.StartBtn.Text = "&Start";
			this.StartBtn.UseVisualStyleBackColor = true;
			this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
			// 
			// ResultTBx
			// 
			this.ResultTBx.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ResultTBx.Location = new System.Drawing.Point(3, 78);
			this.ResultTBx.Multiline = true;
			this.ResultTBx.Name = "ResultTBx";
			this.ResultTBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.ResultTBx.Size = new System.Drawing.Size(394, 557);
			this.ResultTBx.TabIndex = 8;
			// 
			// ChartPanel
			// 
			this.ChartPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ChartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ChartPanel.Location = new System.Drawing.Point(403, 3);
			this.ChartPanel.Name = "ChartPanel";
			this.tableLayoutPanel1.SetRowSpan(this.ChartPanel, 2);
			this.ChartPanel.Size = new System.Drawing.Size(535, 632);
			this.ChartPanel.TabIndex = 7;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(941, 638);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "MainForm";
			this.Text = "Fabolous Coders - Qualification Round";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button StopBtn;
		private System.Windows.Forms.TextBox PathTBx;
		private System.Windows.Forms.Button BrowseBtn;
		private System.Windows.Forms.Button StartBtn;
		private System.Windows.Forms.TextBox ResultTBx;
		private System.Windows.Forms.Panel ChartPanel;
	}
}

