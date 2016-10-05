namespace Muledump
{
	partial class AboutForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.hiddenLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// hiddenLabel
			// 
			this.hiddenLabel.BackColor = System.Drawing.Color.Transparent;
			this.hiddenLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hiddenLabel.Location = new System.Drawing.Point(0, 0);
			this.hiddenLabel.Name = "hiddenLabel";
			this.hiddenLabel.Size = new System.Drawing.Size(256, 254);
			this.hiddenLabel.TabIndex = 0;
			this.hiddenLabel.Click += new System.EventHandler(this.hiddenLabel_Click);
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(256, 254);
			this.Controls.Add(this.hiddenLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AboutForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label hiddenLabel;
	}
}