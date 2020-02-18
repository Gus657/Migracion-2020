using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace migracion_2020
{
	class SQL_Requisitos
	{
		SQL_Conexion conectar = new SQL_Conexion();
		public string ConsultarEntrevista( string tramite)
		{

			string sql = "SELECT id_entrevista FROM entrevistas WHERE id_solicitud=" +
				"(SELECT id_solicitud FROM solicitudes WHERE id_cita=(" +
				"SELECT id_cita FROM citas WHERE id_aceptacion=(" +
				"SELECT id_aceptacion FROM aceptaciones_documentos WHERE id_recepcion=(" +
				"SELECT id_recepcion FROM recepciones_documentos WHERE id_tramite=("+tramite+ ")) AND estado_cita='Activado'))) AND resultado_entrevista!='0' LIMIT 1";
			string respuesta = "";
			OdbcConnection con = conectar.conexion();
			OdbcCommand command = new OdbcCommand(sql, con);
			OdbcDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				respuesta = "SI";
			}
			else
			{
				respuesta = "NO";
			}
			conectar.Desconexion(con);
			return respuesta;

		}
		public string ConsultarPasaporte(string cui)
		{

			string sql = "SELECT id_pasaporte FROM pasaportes WHERE cui='" +cui+"' AND estado_pasaporte='Activo'";
			string respuesta = "";
			OdbcConnection con = conectar.conexion();
			OdbcCommand command = new OdbcCommand(sql, con);
			OdbcDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				respuesta = "SI";
			}
			else
			{
				respuesta = "NO";
			}
			conectar.Desconexion(con);
			return respuesta;

		}
		public string ConsultarIdPasaporte(string cui)
		{

			string sql = "SELECT id_pasaporte FROM pasaportes WHERE cui='" + cui + "' AND estado_pasaporte='Activo'";
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
				respuesta = "NO";
			}
			conectar.Desconexion(con);
			return respuesta;

		}
		public string ConsultarOrdendeImpresion(string cui)
		{
			string respuesta = "";
			if (ConsultarIdPasaporte(cui)!="NO")
			{
				string sql = "SELECT id_orden_impresion FROM ordenes_de_impresiones WHERE id_pasaporte=" + ConsultarIdPasaporte(cui) + " AND estado_orden_impresion='Activo'";
				
				OdbcConnection con = conectar.conexion();
				OdbcCommand command = new OdbcCommand(sql, con);
				OdbcDataReader reader = command.ExecuteReader();
				if (reader.HasRows)
				{
					respuesta = "SI";
				}
				else
				{
					respuesta = "NO";
				}
				conectar.Desconexion(con);

			}
			else
			{
				respuesta = "NO";
			}
			return respuesta;

		}


	}
}
