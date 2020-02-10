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
	public partial class Recuperar : Form
	{
		public Recuperar()
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
			SQL_Recuperar test = new SQL_Recuperar();
			ConfirmarSMS mess = new ConfirmarSMS();
			SQL_Login log = new SQL_Login();
			if (test.ConsultarCuenta(txtCUI.Text, txtEmail.Text))
			{
				string tel = log.ConsultarTelUsuario(txtCUI.Text);
				if (tel != "0")
				{
					Console.WriteLine(tel);
					mess.enviarAviso(tel);

				}
				this.Hide();
				Cambio nuevo = new Cambio(txtCUI.Text);
				nuevo.Show();
			}
			else
			{
				MessageBox.Show("Por favor Verifique los datos ingresados.");
			}

			
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
