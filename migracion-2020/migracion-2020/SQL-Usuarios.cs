﻿using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace migracion_2020
{
	class SQL_Usuarios
	{
		SQL_Conexion conectar = new SQL_Conexion();
		public void Ingresar_Usuario(string cui, string pass, string nom, string ape, string email, string tel)
		{

			string sql = "INSERT INTO usuarios (`cui`, `password_usuario`, `nombre_usuario`, `apellido_usuario`, `email_usuario`, `telefono_usuario`, `estado_usuario`)" +
				" VALUES ('" + cui + "', MD5('"+pass+"'), '"+nom+"','"+ape+"','"+email+"','"+tel+"','Activo');";
			OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
			command.ExecuteNonQuery();

		}
	}
}
