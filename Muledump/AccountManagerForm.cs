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

namespace Muledump
{
	public partial class AccountManagerForm : Form
	{
		public Random r = new Random(Environment.TickCount);
		public Dictionary<int, ItemSprite> totalsSprites = new Dictionary<int, ItemSprite>();

		public AccountManagerForm()
		{
			InitializeComponent();
		}

		private void optionsButton_Click(object sender, EventArgs e)
		{
			var optionsForm = new OptionsForm();
			AddOwnedForm(optionsForm);
			optionsForm.ShowDialog();
		}

		private void aboutButton_Click(object sender, EventArgs e)
		{
			var aboutForm = new AboutForm();
			aboutForm.ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int id = 0;
			do { id = r.Next(2000, 4000); }
			while (!File.Exists("i/" + id + ".png"));
			if (!totalsSprites.ContainsKey(id))
			{
				ItemSprite item = new ItemSprite();
				item = new ItemSprite();
				item.MouseEnter += new EventHandler(mouseEnterSprite);
				item.MouseLeave += new EventHandler(mouseLeaveSprite);
				item.ImageLocation = "i/" + id + ".png";
				item.Height = 40;
				item.Width = 40;
				item.Location = new Point(0, 0);
				item.Margin = new Padding(0);
				item.Padding = new Padding(0);
				item.itemId = id;
				item.itemQuantity = r.Next(0, 10000);
				item.text = new Label();
				item.text.Margin = new Padding(0);
				item.text.Padding = new Padding(0);
				item.text.Text = ToString(item.itemQuantity);
				item.text.Location = new Point(item.Location.X, item.Location.Y);
				totalsSprites.Add(item.itemId, item);
				totalsLayoutPanel.Controls.Add(item);
				totalsLayoutPanel.Refresh();
			}
		}

		private void mouseEnterSprite(object sprite, EventArgs e)
		{
			((ItemSprite)sprite).BackColor = Color.FromArgb(48, 48, 48);
		}

		private void mouseLeaveSprite(object sprite, EventArgs e)
		{
			((ItemSprite)sprite).BackColor = Color.FromArgb(24, 24, 24);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int id = 0;
			do { id = r.Next(2000, 4000); }
			while (!totalsSprites.ContainsKey(id));

			totalsLayoutPanel.Controls.Remove(totalsSprites[id]);
			totalsSprites.Remove(id);
			//totalsLayoutPanel.Refresh();
		}

		private string ToString(int i)
		{
			return i.ToString();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Account acc = new Account();
			acc.c = new Character[1] { new Character() };
			acc.c[0].inv = new Inventory[1] { new Inventory() };
			acc.c[0].inv[0].items = new ItemSprite[8] { new ItemSprite(), new ItemSprite(), new ItemSprite(), new ItemSprite(), new ItemSprite(), new ItemSprite(), new ItemSprite(), new ItemSprite() };
			for(int a = 0; a < acc.c[0].inv[0].items.Length; a++)
			{
				var item = createItem(a + 2600);
				acc.c[0].inv[0].items[a] = item;
			}
			accountLayoutPanel.Controls.Add(acc);
			accountLayoutPanel.Refresh();
		}

		private void button4_Click(object sender, EventArgs e)
		{

		}

		private ItemSprite createItem(int id)
		{
			ItemSprite item = new ItemSprite();
			item = new ItemSprite();
			item.MouseEnter += new EventHandler(mouseEnterSprite);
			item.MouseLeave += new EventHandler(mouseLeaveSprite);
			item.ImageLocation = "i/" + id + ".png";
			item.Height = 40;
			item.Width = 40;
			item.Location = new Point(0, 0);
			item.Margin = new Padding(0);
			item.Padding = new Padding(0);
			item.itemId = id;
			item.itemQuantity = r.Next(0, 10000);
			item.text = new Label();
			item.text.Margin = new Padding(0);
			item.text.Padding = new Padding(0);
			item.text.Text = ToString(item.itemQuantity);
			item.text.Location = new Point(item.Location.X, item.Location.Y);
			return item;
		}
	}

	public class Credentials
	{
		public string email;
		public string password;
	}

	public class ItemSprite : PictureBox
	{
		public Label text;
		public int itemId;
		public bool itemShowText;
		public int itemQuantity;
	}

	public class Inventory : Control
	{
		public ItemSprite[] items = new ItemSprite[] { };
	}

	public class Character : Control
	{
		public Inventory[] inv = new Inventory[] { };
		public bool backpack = false;
	}

	public class Account : Control
	{
		public Credentials creds = new Credentials();
		public Character[] c = new Character[] { };
		public Inventory[] vaults = new Inventory[] { };
		public TextBox email;
		public Label name;
		public Label stars;
	}
}
