using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;


namespace migracion_2020
{
	class SQL_Conexion
	{

		public OdbcConnection conexion()
		{
			OdbcConnection conn = new OdbcConnection("Dsn=Migracion");// creacion de la conexion via ODBC
			try
			{
				conn.Open();
			}
			catch (OdbcException)
			{
				Console.WriteLine("No Conectó");
			}
			return conn;
		}

		public void Desconexion(OdbcConnection conn)
		{
			try
			{
				conn.Close();
			}
			catch (OdbcException)
			{
				Console.WriteLine("No Conectó");
			}
			
		}

	}
}
