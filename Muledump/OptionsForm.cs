using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muledump
{
	public partial class OptionsForm : Form
	{
		public OptionsForm()
		{
			InitializeComponent();
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if(keyData == Keys.Escape)
			{
				Close();
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void SaveSettings()
		{

		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			SaveSettings();
			Close();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DialogResult dr = colorDialog1.ShowDialog();
			if(dr == DialogResult.OK)
			{
				BackColor = colorDialog1.Color;
				Owner.BackColor = colorDialog1.Color;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult dr = fontDialog1.ShowDialog();
			if(dr == DialogResult.OK)
			{
				foreach(Control c in Controls)
				{
					c.Font = fontDialog1.Font;
					c.Refresh();
				}
				foreach(Control c in Owner.Controls)
				{
					c.Font = fontDialog1.Font;
					c.Refresh();
				}
			}
		}
	}
}
