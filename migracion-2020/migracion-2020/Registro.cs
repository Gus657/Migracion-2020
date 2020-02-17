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
	public partial class Registro : Form
	{
		public Registro()
		{
			InitializeComponent();
		}

		private void PictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void Button1_MouseDown(object sender, MouseEventArgs e)
		{
			System.Drawing.Color CelesteGob = System.Drawing.ColorTranslator.FromHtml("#049dd9");
			pictureBox4.BackgroundImage= global::migracion_2020.Properties.Resources.button_round;
			button1.BackColor = CelesteGob;
			button1.FlatAppearance.BorderColor = CelesteGob;
		}

		private void Button1_MouseEnter(object sender, EventArgs e)
		{
			System.Drawing.Color AzulGob = System.Drawing.ColorTranslator.FromHtml("#024873");
			pictureBox4.BackgroundImage = global::migracion_2020.Properties.Resources.button_round_hover;
			button1.BackColor = AzulGob;
			button1.FlatAppearance.BorderColor = AzulGob;
		}

		private void Button1_Click(object sender, EventArgs e)
		{
		}

		private void Button1_MouseLeave(object sender, EventArgs e)
		{
			System.Drawing.Color CelesteGob = System.Drawing.ColorTranslator.FromHtml("#049dd9");
			pictureBox4.BackgroundImage = global::migracion_2020.Properties.Resources.button_round;
			button1.BackColor = CelesteGob;
			button1.FlatAppearance.BorderColor = CelesteGob;
		}

		private void Button1_Click_1(object sender, EventArgs e)
		{
			SQL_Usuarios users = new SQL_Usuarios();
			users.Ingresar_Usuario(txtCUI.Text,txtPass.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, txtTelefono.Text);
			this.Hide();
			LogIn nuevo = new LogIn();
			nuevo.Show();
		}

		private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void Label6_Click(object sender, EventArgs e)
		{

		}
	}
}
