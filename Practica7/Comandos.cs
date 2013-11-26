using System;
using MySql.Data.MySqlClient;

namespace Practica7

{
	public class Comandos : MySQL
	{
		public Comandos ()
		{

		}
		
		public void mostrarTodos(){
			try{
				Console.WriteLine("Abriendo conexion");
			this.abrirConexion();
				Console.WriteLine("Conexion abierta \n ejecutando comando");
            MySqlCommand myCommand = new MySqlCommand(this.querySelect(),myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();	
	        while (myReader.Read()){
	            int id = Convert.ToInt32 (myReader["id"]);
	            string nombre = myReader["nombre"].ToString();
	            string codigo = myReader["codigo"].ToString();
				string telefono = myReader["telefono"].ToString();
				string email = myReader["email"].ToString();

	            Console.WriteLine(
		        		"ID: " + id 
					+ "\n|Nombre: " + nombre + "|"
				    + "\n|Codigo: " + codigo + "|"
					+ "\n|Telefono: " + telefono + "|"
					+ "\n|E-mail: " + email + ""
					);
	       }
			
			
            myReader.Close();
			myReader = null;
            myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();

				}catch(Exception){
				Console.Clear();
				Console.WriteLine("Error al obtener la informacion");
			}
		}
		
		public void insertarRegistroNuevo(string nombre, string codigo, string telefono, string email){

			this.abrirConexion();
			string sql = (
				"INSERT INTO " +
				"`alumno` (" +
					"`nombre`, " +
					"`codigo`" +
					"`telefono`" +
					"`email `" +
					") VALUES (" +
					"'" + nombre + "'," +
					"'" + codigo + "'," +
					"'" + telefono + "'," +
					"'" + email +
				"')"
				);
			this.ejecutarComando(sql);
			this.cerrarConexion();
		
		}
		
		public void editarCodigoRegistro(int id, string codigo){
			this.abrirConexion();
			string sql = "UPDATE `alumno` SET `codigo`='" + codigo + "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}

		public void eliminarRegistro(int id){
			this.abrirConexion();
			string sql = "DELETE FROM `alumno` WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		private int ejecutarComando(string sql){
			MySqlCommand myCommand = new MySqlCommand(sql,this.myConnection);
			int afectadas = myCommand.ExecuteNonQuery();
			myCommand.Dispose();
			myCommand = null;
			return afectadas;
		}
		
		private string querySelect(){
			return "SELECT * " +
	           	"FROM alumno";
		}
	}
}

