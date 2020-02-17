using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace migracion_2020
{
	class SQL_LLenar_Tabla
	{
		SQL_Conexion conectar = new SQL_Conexion();
		public OdbcDataAdapter llenaTbl(string tabla, string cui)// metodo  que obtinene el contenio de una tabla
		{
			
			string sql = "SELECT id_tramite AS 'Numero Tramite',fecha_apertura_tramite FROM " + tabla + " WHERE cui='"+cui+"'  ;";
			OdbcConnection con = conectar.conexion();
			OdbcDataAdapter dataTable = new OdbcDataAdapter(sql,con);
			conectar.Desconexion(con);
			return dataTable;
		}
	}
}
