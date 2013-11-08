using System;
using MySql.Data.MySqlClient;

namespace Practica7
{
	class MainClass
	{
		public static void Main (string[] args)
		{	int sel;

			Comandos com = new Comandos();
		menu:
			Console.Clear();
			Console.WriteLine(
				"*****MENU*****\n"
				+ "+ 1) Mostrar Todos\n"
				+ "+ 2) Agregar Nuevo Usuario\n"
				+ "+ 3) Editar Registro\n"
				+ "+ 4) Elimianar Registro\n"
				+ "+ 5) Salir"
				);

			sel = Convert.ToInt32(Console.ReadLine());

			switch(sel){
			case 1:
				com.mostrarTodos();
				Console.ReadKey(true);
				goto menu;

			case 2:
				Console.Clear();
				new MainClass().nvoRegistro();
				goto menu;

			case 3:
				break;

			case 4:
				break;

			case 5:
				break;
			
			}		
		}

		public void nvoRegistro ()
		{
			Comandos com = new Comandos();

			Console.Write("Ingrese los sigueintes datos\nNombre: ");
			String nombreN = Console.ReadLine();
			Console.Write("\nCodigo: ");
			String codigoN = Console.ReadLine();
			Console.Write("\nTelefono: ");
			String telefonoN = Console.ReadLine();
			Console.Write("\nEmail: ");
			String emailN = Console.ReadLine();

			com.insertarRegistroNuevo(nombreN, codigoN, telefonoN, emailN);
		}

	}
}
