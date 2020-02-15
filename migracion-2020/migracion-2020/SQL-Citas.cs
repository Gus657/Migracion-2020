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
			string sql = "INSERT INTO citas (cui,aceptacion,fecha_bitacora) VALUES ('" + cui + "','" + aceptacion + "','" + fecha + "','" + hora + "');";
			OdbcConnection con = conectar.conexion();
			OdbcCommand command = new OdbcCommand(sql, con);
			command.ExecuteNonQuery();
			conectar.Desconexion(con);
		}
	}
}
