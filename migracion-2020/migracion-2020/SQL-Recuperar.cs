using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace migracion_2020
{
	class SQL_Recuperar
	{
		SQL_Conexion conectar = new SQL_Conexion();
		public Boolean ConsultarCuenta(string cui, string email)
		{

			string sql = "SELECT estado_usuario FROM usuarios WHERE cui='" + cui + "' AND email_usuario='" + email + "';";
			bool respuesta = false;
			OdbcConnection con = conectar.conexion();
			OdbcCommand command = new OdbcCommand(sql, con);
			OdbcDataReader reader = command.ExecuteReader();
			if (reader.HasRows && reader.GetValue(0).ToString() == "Activo")
			{
				respuesta = true;
			}
			else
			{
				respuesta = false;
			}
			conectar.Desconexion(con);
			return respuesta;
		}
	}
}
