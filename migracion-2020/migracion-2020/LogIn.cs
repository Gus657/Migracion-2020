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
	public partial class LogIn : Form
	{
		SQL_Login test = new SQL_Login();
		ConfirmarSMS mess = new ConfirmarSMS();
		SQL_Bitacora log = new SQL_Bitacora();
		public LogIn()
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

			if (test.ConsultarUsuario(txtCUI.Text, txtContraseña.Text))
			{
				DateTime today = DateTime.Today;
				log.Ingresar_Bitacora(txtCUI.Text, "Ingreso al Sistema", today.ToString());
				this.Hide();
				Inicio nuevo = new Inicio(txtCUI.Text);
				nuevo.Show();
				
			}
			else
			{
				MessageBox.Show("Por favor Verifique los datos ingresados.");
				DateTime today = DateTime.Today;
				log.Ingresar_Bitacora("3525037500101", "Falló al interntar ingresar al sistema", today.ToString());
			}
			
		}

		private void Button1_MouseLeave(object sender, EventArgs e)
		{
			System.Drawing.Color CelesteGob = System.Drawing.ColorTranslator.FromHtml("#049dd9");
			pictureBox4.BackgroundImage = global::migracion_2020.Properties.Resources.button_round;
			button1.BackColor = CelesteGob;
			button1.FlatAppearance.BorderColor = CelesteGob;
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Registro nuevo = new Registro();
			nuevo.Show();
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			
			this.Hide();
			Recuperar nuevo = new Recuperar();
			nuevo.Show();
		}
	}
}
