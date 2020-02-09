using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace migracion_2020
{
	public partial class Principal : Form
	{
		public void setButtonsColors(Button c)
		{
			System.Drawing.Color CelesteGob = System.Drawing.ColorTranslator.FromHtml("#049dd9");
			button1.BackColor = Color.White ;
			button1.ForeColor = Color.Black;
			button1.FlatAppearance.MouseOverBackColor = Color.LightGray;
			button2.BackColor = Color.White;
			button2.ForeColor = Color.Black;
			button2.FlatAppearance.MouseOverBackColor = Color.LightGray;
			button3.BackColor = Color.White;
			button3.ForeColor = Color.Black;
			button3.FlatAppearance.MouseOverBackColor = Color.LightGray;
			button4.BackColor = Color.White;
			button4.ForeColor = Color.Black;
			button4.FlatAppearance.MouseOverBackColor = Color.LightGray;
			button5.BackColor = Color.White;
			button5.ForeColor = Color.Black;
			button5.FlatAppearance.MouseOverBackColor = Color.LightGray;
			button6.BackColor = Color.White;
			button6.ForeColor = Color.Black;
			button6.FlatAppearance.MouseOverBackColor = Color.LightGray;

			c.BackColor = CelesteGob;
			c.ForeColor = Color.White;
			c.FlatAppearance.MouseOverBackColor = CelesteGob;
		}
		private void HideAllTabsOnTabControl(TabControl theTabControl)
		{
			theTabControl.Appearance = TabAppearance.FlatButtons;
			theTabControl.ItemSize = new Size(0, 1);
			theTabControl.SizeMode = TabSizeMode.Fixed;
		}
		public Principal()
		{
			InitializeComponent();
			setButtonsColors(button1);

		}

		private void Button1_Click_1(object sender, EventArgs e)
		{
			setButtonsColors(button1);
			tabControl1.SelectedIndex = 0;
		
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			setButtonsColors(button2);
			tabControl1.SelectedIndex = 1;
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			setButtonsColors(button3);
			tabControl1.SelectedIndex = 2;
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			setButtonsColors(button4);
			tabControl1.SelectedIndex = 3;
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			setButtonsColors(button5);
			tabControl1.SelectedIndex = 4;
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedIndex = 6;
			setButtonsColors(button6);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			HideAllTabsOnTabControl(tabControl1);
		}

		private void Principal_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
