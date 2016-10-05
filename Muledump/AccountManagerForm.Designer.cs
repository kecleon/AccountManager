namespace Muledump
{
	partial class AccountManagerForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountManagerForm));
			this.reloadAllButton = new System.Windows.Forms.Button();
			this.optionsButton = new System.Windows.Forms.Button();
			this.optionsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.aboutButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.totalsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.accountLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.optionsLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// reloadAllButton
			// 
			this.reloadAllButton.Location = new System.Drawing.Point(3, 3);
			this.reloadAllButton.Name = "reloadAllButton";
			this.reloadAllButton.Size = new System.Drawing.Size(75, 23);
			this.reloadAllButton.TabIndex = 0;
			this.reloadAllButton.Text = "Reload All";
			this.reloadAllButton.UseVisualStyleBackColor = true;
			// 
			// optionsButton
			// 
			this.optionsButton.Location = new System.Drawing.Point(84, 3);
			this.optionsButton.Name = "optionsButton";
			this.optionsButton.Size = new System.Drawing.Size(75, 23);
			this.optionsButton.TabIndex = 1;
			this.optionsButton.Text = "Options";
			this.optionsButton.UseVisualStyleBackColor = true;
			this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
			// 
			// optionsLayoutPanel
			// 
			this.optionsLayoutPanel.AutoSize = true;
			this.optionsLayoutPanel.Controls.Add(this.reloadAllButton);
			this.optionsLayoutPanel.Controls.Add(this.optionsButton);
			this.optionsLayoutPanel.Controls.Add(this.aboutButton);
			this.optionsLayoutPanel.Controls.Add(this.button1);
			this.optionsLayoutPanel.Controls.Add(this.button2);
			this.optionsLayoutPanel.Controls.Add(this.button3);
			this.optionsLayoutPanel.Controls.Add(this.button4);
			this.optionsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.optionsLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.optionsLayoutPanel.Name = "optionsLayoutPanel";
			this.optionsLayoutPanel.Size = new System.Drawing.Size(826, 29);
			this.optionsLayoutPanel.TabIndex = 2;
			// 
			// aboutButton
			// 
			this.aboutButton.Location = new System.Drawing.Point(165, 3);
			this.aboutButton.Name = "aboutButton";
			this.aboutButton.Size = new System.Drawing.Size(75, 23);
			this.aboutButton.TabIndex = 3;
			this.aboutButton.Text = "About";
			this.aboutButton.UseVisualStyleBackColor = true;
			this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(246, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(327, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Remove";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// totalsLayoutPanel
			// 
			this.totalsLayoutPanel.AutoScroll = true;
			this.totalsLayoutPanel.Location = new System.Drawing.Point(12, 35);
			this.totalsLayoutPanel.Name = "totalsLayoutPanel";
			this.totalsLayoutPanel.Size = new System.Drawing.Size(802, 183);
			this.totalsLayoutPanel.TabIndex = 3;
			// 
			// flowLayoutPanel1
			// 
			this.accountLayoutPanel.Location = new System.Drawing.Point(12, 224);
			this.accountLayoutPanel.Name = "flowLayoutPanel1";
			this.accountLayoutPanel.Size = new System.Drawing.Size(802, 347);
			this.accountLayoutPanel.TabIndex = 0;
			// 
			// button3
			// 
			this.button3.AutoSize = true;
			this.button3.Location = new System.Drawing.Point(408, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(79, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "Add Account";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(493, 3);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(98, 23);
			this.button4.TabIndex = 7;
			this.button4.Text = "Remove Account";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// AccountManagerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
			this.ClientSize = new System.Drawing.Size(826, 583);
			this.Controls.Add(this.accountLayoutPanel);
			this.Controls.Add(this.totalsLayoutPanel);
			this.Controls.Add(this.optionsLayoutPanel);
			this.ForeColor = System.Drawing.Color.White;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AccountManagerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Account Manager 0.1";
			this.optionsLayoutPanel.ResumeLayout(false);
			this.optionsLayoutPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button reloadAllButton;
		private System.Windows.Forms.Button optionsButton;
		private System.Windows.Forms.FlowLayoutPanel optionsLayoutPanel;
		private System.Windows.Forms.Button aboutButton;
		private System.Windows.Forms.FlowLayoutPanel totalsLayoutPanel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.FlowLayoutPanel accountLayoutPanel;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}

