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
				goto menu;

			case 2:
				goto menu;

			case 3:
				break;

			case 4:
				break;

			case 5:
				break;
			
			}		}
	}
}
