using System;
using MySql.Data.MySqlClient;

namespace Practica7
{
	public class Conexion
	{
		public Conexion ()
		{
		}

		private MySqlConnection conexion;
		private String server = "localhost";
		private String database = "Prueba";
		private String user = "root";
		private String pass = "Anerol88";
		private Boolean pooling = false; 
		/**private String cadenaConexion = (
			"server = " + server + ";"
			+ "database = " + database + ";"
			+ "user = " + user + ";"
			+ "password = " + pass + ";"
			+ "pooling = " + pooling + ";"
			);
*/
		public void conectar ()
		{

		}
	}
}

