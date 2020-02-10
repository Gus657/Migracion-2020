using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace migracion_2020
{
	class ConfirmarSMS
	{
		public Boolean enviarConfirmacion(String numero)
		{
			bool enviado = false;

			try
			{
				WebClient cliente = new WebClient();
				Stream str = cliente.OpenRead(string.Format("https://platform.clickatell.com/messages/http/send?apiKey=ocLN2GHZTkCpRDnSFNkuQg==&to=50242207518&content=Bienvenido+a+portal+migracion",numero,"Hola"));
				StreamReader reader = new StreamReader(str);
				string resultado = reader.ReadToEnd();
				Console.WriteLine(resultado);

			}
			catch (Exception ex)
			{

				enviado = false;
			}

			return enviado;

		}


		public Boolean enviarAviso(String numero)
		{
			bool enviado = false;

			try
			{
				WebClient cliente = new WebClient();
				Stream str = cliente.OpenRead(string.Format("https://platform.clickatell.com/messages/http/send?apiKey=ocLN2GHZTkCpRDnSFNkuQg==&to="+"+50242207518"+"&content=Se+está+restableciendo+contraseña", "+50235572376", "Hola"));
				StreamReader reader = new StreamReader(str);
				string resultado = reader.ReadToEnd();
				Console.WriteLine(resultado);

			}
			catch (Exception ex)
			{

				enviado = false;
			}

			return enviado;

		}

		public Boolean enviarAvisoPass(String numero)
		{
			bool enviado = false;

			try
			{
				WebClient cliente = new WebClient();
				Stream str = cliente.OpenRead(string.Format("https://platform.clickatell.com/messages/http/send?apiKey=ocLN2GHZTkCpRDnSFNkuQg==&to=50242207518&content=Se+ha+cambiado+su+contraseña", numero, "Hola"));
				StreamReader reader = new StreamReader(str);
				string resultado = reader.ReadToEnd();
				Console.WriteLine(resultado);

			}
			catch (Exception ex)
			{

				enviado = false;
			}

			return enviado;

		}
	}
}
