using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace migracion_2020
{
	class SQL_CambioPass
	{
		SQL_Conexion conectar = new SQL_Conexion();
		public void Update_Pass(string cui, string pass)
		{

			string sql = "UPDATE usuarios SET password_usuario=MD5('"+pass+"') WHERE cui='"+cui+"';";
			OdbcConnection con = conectar.conexion();
			OdbcCommand command = new OdbcCommand(sql, con);
			command.ExecuteNonQuery();
			conectar.Desconexion(con);

		}
	}
}
