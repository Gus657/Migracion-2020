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
		public void Ingresar_Transacciones(string nom, string cui	, string fecha)
		{

			string sql = "INSERT INTO tramites(nombre_tramite,tipo_tramite,cui,fecha_apertura_tramite,estado_tramite)" +
				"  VALUES ('" + nom + "','0','" + cui + "','" + fecha + "','Activado');";
			Console.WriteLine(sql);
			OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
			command.ExecuteNonQuery();

		}
		public void Ingresar_Progreso(string nom, string cui)
		{

			string sql = "	INSERT INTO progreso (id_tramite,progreso,estado_progreso)" +
				"  VALUES ((SELECT id_tramite FROM tramites WHERE cui='" + cui + "' and nombre_tramite='" + nom + "' LIMIT 1), '0%','Activo');";
			Console.WriteLine(sql);
			OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
			command.ExecuteNonQuery();

		}
		public string ConsultarIdTramites(string nom, string cui)
		{

			string sql = "SELECT id_tramite FROM tramites WHERE cui='" + cui + "' and nombre_tramite='" + nom + "' LIMIT 1;";
			string respuesta = "";
			OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
			OdbcDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				respuesta = reader.GetValue(0).ToString();
			}
			else
			{
				respuesta = "0";
			}
			return respuesta;
		}
		public string ConsultarProgreso(string idTramite)
		{

			string sql = "SELECT progreso FROM progreso WHERE id_tramite="+idTramite+" LIMIT 1;";
			string respuesta = "";
			OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
			OdbcDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				respuesta = reader.GetValue(0).ToString();
			}
			else
			{
				respuesta = "0";
			}
			return respuesta;
		}


		public void Asignar_Tipo_Tramite(string nom, string cui, string tipo)
		{

			string sql = "UPDATE tramites SET tipo_tramite='"+tipo+"'" +
				" WHERE id_tramite="+ConsultarIdTramites(nom,cui)+";";
			Console.WriteLine(sql);
			OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
			command.ExecuteNonQuery();

		}
	}
}
