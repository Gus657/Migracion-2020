using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace migracion_2020
{
	class SQL_Citas
	{
		SQL_Conexion conectar = new SQL_Conexion();
		public void Ingresar_Cita(string cui, string aceptacion, string fecha, string hora)
		{
			string sql = "INSERT INTO citas (cui,id_aceptacion,fecha_cita,hora_cita,estado_cita) VALUES ('" + cui + "','" + aceptacion + "','" + fecha + "','" + hora + "','Activado');";
			OdbcConnection con = conectar.conexion();
			OdbcCommand command = new OdbcCommand(sql, con);
			command.ExecuteNonQuery();
			conectar.Desconexion(con);
		}
		public string ConsultarCita(string cui)
		{

			string sql = "SELECT id_cita,hora_cita, fecha_cita FROM citas WHERE cui='"+cui+"' AND estado_cita='Activado' ORDER BY id_cita DESC LIMIT 1";
			string respuesta = "";
			OdbcConnection con = conectar.conexion();
			OdbcCommand command = new OdbcCommand(sql, con);
			OdbcDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				respuesta = "Cita No. "+ reader.GetValue(0).ToString() + "\n Fecha: "+reader.GetValue(2).ToString().Substring(0, 10) + "\n Hora: "+reader.GetValue(1).ToString();
			}
			else
			{
				respuesta = "0";
			}
			conectar.Desconexion(con);
			return respuesta;

		}




		public string ConsultarAceptacion(string cui)
		{

			string sql = "SELECT id_aceptacion FROM aceptaciones_documentos WHERE cui='" + cui + "' LIMIT 1;";
			string respuesta = "";
			OdbcConnection con = conectar.conexion();
			OdbcCommand command = new OdbcCommand(sql, con);
			OdbcDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				respuesta = reader.GetValue(0).ToString();
			}
			else
			{
				respuesta = "0";
			}
			conectar.Desconexion(con);
			return respuesta;

		}
	}


}
