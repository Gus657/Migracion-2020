﻿using iTextSharp.text;
using iTextSharp.text.pdf;
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



namespace migracion_2020
{
	
	public partial class Principal : Form
	{
		string nom = "";
		string noCui = "";
		string noTramite = "";
		string progreso = "";
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
		public Principal(string nomT, string Cui)
		{
            noTramite = nomT;
			nom = nomT;
			noCui=Cui;
			InitializeComponent();
			SQL_tramites tra = new SQL_tramites();
			SQL_Usuarios users = new SQL_Usuarios();
			progreso = tra.ConsultarProgreso(nom);
			label4.Text = progreso;
			ConsultarPasos(progreso);
			label3.Text = users.ConsultarNombre(noCui);
			setButtonsColors(button1);
            verifica1.cui = noCui;
			
		}
		void ConsultarPasos(string progreso)
		{
			switch (progreso)
			{
				case "0%":
					picPaso1.BackgroundImage = global::migracion_2020.Properties.Resources.one_no;
					picPaso2.BackgroundImage = global::migracion_2020.Properties.Resources.two_no;
					picPaso3.BackgroundImage = global::migracion_2020.Properties.Resources.three_no;
					picPaso4.BackgroundImage = global::migracion_2020.Properties.Resources.four_no;
					picPaso5.BackgroundImage = global::migracion_2020.Properties.Resources.five_no;
					lblPasoXdeX.Text = "Paso 0 de 5";
					lblTextoX.Text = "Por favor realice la entrega de su documentos";
					break;
				case "20%":
					picPaso1.BackgroundImage = global::migracion_2020.Properties.Resources.one;
					picPaso2.BackgroundImage = global::migracion_2020.Properties.Resources.two_no;
					picPaso3.BackgroundImage = global::migracion_2020.Properties.Resources.three_no;
					picPaso4.BackgroundImage = global::migracion_2020.Properties.Resources.four_no;
					picPaso5.BackgroundImage = global::migracion_2020.Properties.Resources.five_no;
					lblPasoXdeX.Text = "Paso 1 de 5";
					lblTextoX.Text = "Felicidades, sus documentos han sido entregados, por favor espere una respuesta del sistema.";
					break;
				case "40%":
					picPaso1.BackgroundImage = global::migracion_2020.Properties.Resources.one;
					picPaso2.BackgroundImage = global::migracion_2020.Properties.Resources.two;
					picPaso3.BackgroundImage = global::migracion_2020.Properties.Resources.three_no;
					picPaso4.BackgroundImage = global::migracion_2020.Properties.Resources.four_no;
					picPaso5.BackgroundImage = global::migracion_2020.Properties.Resources.five_no;
					lblPasoXdeX.Text = "Paso 2 de 5";
					lblTextoX.Text = "Sus documentos han sido revisados";
					break;
				case "60%":
					picPaso1.BackgroundImage = global::migracion_2020.Properties.Resources.one;
					picPaso2.BackgroundImage = global::migracion_2020.Properties.Resources.two;
					picPaso3.BackgroundImage = global::migracion_2020.Properties.Resources.three;
					picPaso4.BackgroundImage = global::migracion_2020.Properties.Resources.four_no;
					picPaso5.BackgroundImage = global::migracion_2020.Properties.Resources.five_no;
					lblPasoXdeX.Text = "Paso 3 de 5";
					lblTextoX.Text = "Felicidades sus documentos han sido aceptados, para realizar el tramite. \n Ahora deberá agendar una cita para llevar a cabo los tramites internos en la Direccion General de Migración. Por favor tome en cuenta los horarios y fechas disponibles al momento de solictar su cita.";
					break;
				case "80%":
					picPaso1.BackgroundImage = global::migracion_2020.Properties.Resources.one;
					picPaso2.BackgroundImage = global::migracion_2020.Properties.Resources.two;
					picPaso3.BackgroundImage = global::migracion_2020.Properties.Resources.three;
					picPaso4.BackgroundImage = global::migracion_2020.Properties.Resources.four;
					picPaso5.BackgroundImage = global::migracion_2020.Properties.Resources.five_no;
					lblPasoXdeX.Text = "Paso 4 de 5";
					lblTextoX.Text = "Su preceso de gestión está siendo realizado internamiente en la dirección general de migración, por favor sea paciente, en breve terminaremos el proceso.";
					break;
				case "100%":
					picPaso1.BackgroundImage = global::migracion_2020.Properties.Resources.one;
					picPaso2.BackgroundImage = global::migracion_2020.Properties.Resources.two;
					picPaso3.BackgroundImage = global::migracion_2020.Properties.Resources.three;
					picPaso4.BackgroundImage = global::migracion_2020.Properties.Resources.four;
					picPaso5.BackgroundImage = global::migracion_2020.Properties.Resources.five;
					lblPasoXdeX.Text = "Paso 5 de 5";
					lblTextoX.Text = "Felicidades, su pasaporte está listo, por favor verifique la información antes de aceptarlo.";
					break;
				default:
					break;
			}
		}
		private void Button1_Click_1(object sender, EventArgs e)
		{
			setButtonsColors(button1);
			SQL_tramites tra = new SQL_tramites();
			progreso = tra.ConsultarProgreso(nom);
			label4.Text = progreso;
			ConsultarPasos(progreso);
			tabControl1.SelectedIndex = 0;
		
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			setButtonsColors(button2);
			tabControl1.SelectedIndex = 1;
			SQL_tramites tra = new SQL_tramites();
			tra.ActualizarProgreso(nom, "20%");
			progreso = tra.ConsultarProgreso(nom);
			label4.Text = progreso;
			ConsultarPasos(progreso);
			recepcion1.ObtenerCui(noCui);
			recepcion1.ObtenerTramite(noTramite);
			button3.Enabled = true;
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			setButtonsColors(button3);
			SQL_tramites tra = new SQL_tramites();
			tra.ActualizarProgreso(nom, "40%");
			progreso = tra.ConsultarProgreso(nom);
			label4.Text = progreso;
			ConsultarPasos(progreso);
			tabControl1.SelectedIndex = 2;
			button4.Enabled = true;

		}

		private void Button4_Click(object sender, EventArgs e)
		{
			SQL_Citas cita = new SQL_Citas();
			if (cita.ConsultarCita(noCui)!="0")
			{
				button7.Enabled = false;
				lblCita.Text = cita.ConsultarCita(noCui);
			}
			button8.Enabled = true;
			setButtonsColors(button4);
			SQL_tramites tra = new SQL_tramites();
			tra.ActualizarProgreso(nom, "60%");
			progreso = tra.ConsultarProgreso(nom);
			label4.Text = progreso;
			ConsultarPasos(progreso);
			tabControl1.SelectedIndex = 3;
			button5.Enabled = true;
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			SQL_Requisitos requisitos = new SQL_Requisitos();
			// ENTREVISTA
			if (requisitos.ConsultarEntrevista(nom)=="SI")
			{
				pictureBox12.BackgroundImage = global::migracion_2020.Properties.Resources.correct;
			}
			else
			{
				pictureBox12.BackgroundImage = global::migracion_2020.Properties.Resources.no_completo;
			}
			// FOTO
			if (requisitos.ConsultarPasaporte(noCui) == "SI")
			{
				pictureBox13.BackgroundImage = global::migracion_2020.Properties.Resources.correct;
			}
			else
			{
				pictureBox13.BackgroundImage = global::migracion_2020.Properties.Resources.no_completo;
			}
			//ORDEN
			if (requisitos.ConsultarOrdendeImpresion(noCui) == "SI")
			{
				pictureBox14.BackgroundImage = global::migracion_2020.Properties.Resources.correct;
			}
			else
			{
				pictureBox14.BackgroundImage = global::migracion_2020.Properties.Resources.no_completo;
			}
			setButtonsColors(button5);
			SQL_tramites tra = new SQL_tramites();
			tra.ActualizarProgreso(nom, "80%");
			progreso = tra.ConsultarProgreso(nom);
			label4.Text = progreso;
			ConsultarPasos(progreso);
			tabControl1.SelectedIndex = 4;
			button6.Enabled = true;
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			setButtonsColors(button6);
			SQL_tramites tra = new SQL_tramites();
			tra.ActualizarProgreso(nom, "100%");
			progreso = tra.ConsultarProgreso(nom);
			label4.Text = progreso;
			ConsultarPasos(progreso);
			tabControl1.SelectedIndex = 5;
            entregaPasaporte1.getCUI(noCui, noTramite);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			HideAllTabsOnTabControl(tabControl1);
			SQL_Conexion conectar = new SQL_Conexion();
			button3.Enabled = false;
			button4.Enabled = false;
			button5.Enabled = false;
			button6.Enabled = false;

			conectar.conexion();
		}

		private void Principal_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		string GenerarFecha()
		{
			string fechaBase = DateTime.Now.ToString("yy-MM");
			string dia = DateTime.Now.ToString("dd");
			int selecDia = Convert.ToInt32(dia);
			Random rdn = new Random();
			
			string respuesta = "";
			if (comboBox1.Text == "Esta Semana")
			{
				selecDia += rdn.Next(3);
			}
			else if (comboBox1.Text == "La Próxima semana")
			{
				selecDia += rdn.Next(10);
			}
			else
			{
				selecDia += rdn.Next(3);
			}
			selecDia += rdn.Next(3)+1;
			respuesta = fechaBase + "-" + selecDia;
			Console.WriteLine(respuesta);
			return respuesta;
		}
		string GenerarHora()
		{
			string respuesta = "";
			Random rdn = new Random();


			if (comboBox2.Text == "Por la Mañana (07 AM - 11 AM)")
			{
				respuesta += (7 + rdn.Next(4)).ToString();
			}
			else if (comboBox2.Text == "Por la Tarde      (12 PM -  04 PM)")
			{
				respuesta += (12 + rdn.Next(4)).ToString();
			}
			else
			{
				respuesta += (12 + rdn.Next(4)).ToString();
			}
			respuesta += ":00:00";
			Console.WriteLine(respuesta);
			return respuesta;
		}
		private void Button7_Click(object sender, EventArgs e)
		{
			SQL_Citas cita = new SQL_Citas();
			cita.Ingresar_Cita(noCui,cita.ConsultarAceptacion(noCui),GenerarFecha(),GenerarHora());
			lblCita.Text=cita.ConsultarCita(noCui);
			button8.Enabled = true;
			button7.Enabled = false;
		}

		private void Button8_Click(object sender, EventArgs e)
		{
			Document document = new Document(iTextSharp.text.PageSize.A8, 15,10,30,10);
			PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(@"PDF\pdf.pdf", FileMode.Create));
			document.Open();
			Paragraph paragraph = new Paragraph(lblCita.Text);
			document.Add(paragraph);
			document.Close();
			System.Diagnostics.Process.Start(@"PDF\pdf.pdf");
		}
	}
}
