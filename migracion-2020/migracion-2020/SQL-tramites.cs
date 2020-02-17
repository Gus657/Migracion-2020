using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace migracion_2020
{
	class SQL_tramites
	{
		SQL_Conexion conectar = new SQL_Conexion();
		public void Ingresar_Transacciones(string cui	, string fecha)
		{

			string sql = "INSERT INTO tramites(tipo_tramite,cui,fecha_apertura_tramite,estado_tramite)" +
				"  VALUES ('0','" + cui + "','" + fecha + "','Activado');";
			OdbcConnection con = conectar.conexion();
			Console.WriteLine(sql);
			OdbcCommand command = new OdbcCommand(sql, con);
			command.ExecuteNonQuery();
			conectar.Desconexion(con);

		}
		public void Ingresar_Progreso( string cui)
		{

			string sql = "	INSERT INTO progreso (id_tramite,progreso,estado_progreso)" +
				"  VALUES ((SELECT id_tramite FROM tramites WHERE cui='" + cui + "' and estado_tramite='Activado' LIMIT 1), '0%','Activo');";
			Console.WriteLine(sql);
			OdbcConnection con = conectar.conexion();
			OdbcCommand command = new OdbcCommand(sql, con);
			command.ExecuteNonQuery();
			conectar.Desconexion(con);

		}
		public string ConsultarIdTramites( string cui)
		{

			string sql = "SELECT id_tramite FROM tramites WHERE cui='" + cui + "' and estado_tramite='Activado' LIMIT 1;";
			string respuesta = "";
			OdbcConnection con = conectar.conexion();
			OdbcCommand command = new OdbcCommand(sql,con);
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
		public string ConsultarProgreso(string idTramite)
		{

			string sql = "SELECT progreso FROM progreso WHERE id_tramite="+idTramite+" LIMIT 1;";
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


		public void Asignar_Tipo_Tramite( string cui, string tipo)
		{

			string sql = "UPDATE tramites SET tipo_tramite='"+tipo+"'" +
				" WHERE id_tramite="+ConsultarIdTramites(cui)+";";
			Console.WriteLine(sql);
			OdbcConnection con = conectar.conexion();
			OdbcCommand command = new OdbcCommand(sql, con);
			command.ExecuteNonQuery();
			conectar.Desconexion(con);

		}
	}
}
