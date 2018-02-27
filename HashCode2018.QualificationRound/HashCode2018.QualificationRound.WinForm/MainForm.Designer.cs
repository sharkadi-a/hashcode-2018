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
			this.PathTBx = new System.Windows.Forms.TextBox();
			this.BrowseBtn = new System.Windows.Forms.Button();
			this.StartBtn = new System.Windows.Forms.Button();
			this.ResultTBx = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.StopBtn = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// PathTBx
			// 
			this.PathTBx.Location = new System.Drawing.Point(22, 12);
			this.PathTBx.Name = "PathTBx";
			this.PathTBx.Size = new System.Drawing.Size(327, 20);
			this.PathTBx.TabIndex = 0;
			this.PathTBx.Text = global::HashCode2018.QualificationRound.WinForm.Properties.Settings.Default.LastFilePath;
			// 
			// BrowseBtn
			// 
			this.BrowseBtn.Location = new System.Drawing.Point(22, 38);
			this.BrowseBtn.Name = "BrowseBtn";
			this.BrowseBtn.Size = new System.Drawing.Size(75, 23);
			this.BrowseBtn.TabIndex = 1;
			this.BrowseBtn.Text = "Browse...";
			this.BrowseBtn.UseVisualStyleBackColor = true;
			this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
			// 
			// StartBtn
			// 
			this.StartBtn.Location = new System.Drawing.Point(103, 38);
			this.StartBtn.Name = "StartBtn";
			this.StartBtn.Size = new System.Drawing.Size(75, 23);
			this.StartBtn.TabIndex = 2;
			this.StartBtn.Text = "Start";
			this.StartBtn.UseVisualStyleBackColor = true;
			// 
			// ResultTBx
			// 
			this.ResultTBx.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ResultTBx.Location = new System.Drawing.Point(0, 83);
			this.ResultTBx.Multiline = true;
			this.ResultTBx.Name = "ResultTBx";
			this.ResultTBx.Size = new System.Drawing.Size(371, 600);
			this.ResultTBx.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(371, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(709, 683);
			this.panel1.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.StopBtn);
			this.panel2.Controls.Add(this.PathTBx);
			this.panel2.Controls.Add(this.BrowseBtn);
			this.panel2.Controls.Add(this.StartBtn);
			this.panel2.Controls.Add(this.ResultTBx);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(371, 683);
			this.panel2.TabIndex = 5;
			// 
			// StopBtn
			// 
			this.StopBtn.Location = new System.Drawing.Point(184, 38);
			this.StopBtn.Name = "StopBtn";
			this.StopBtn.Size = new System.Drawing.Size(75, 23);
			this.StopBtn.TabIndex = 4;
			this.StopBtn.Text = "Stop";
			this.StopBtn.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1080, 683);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox PathTBx;
		private System.Windows.Forms.Button BrowseBtn;
		private System.Windows.Forms.Button StartBtn;
		private System.Windows.Forms.TextBox ResultTBx;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button StopBtn;
	}
}

