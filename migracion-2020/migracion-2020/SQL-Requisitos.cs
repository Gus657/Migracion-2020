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
				"SELECT id_recepcion FROM recepciones_documentos WHERE id_tramite=("+tramite+ ") )) )) AND resultado_entrevista!='0'";
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
		
		
	}
}
