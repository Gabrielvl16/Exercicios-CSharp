using System;

namespace ATIVIDADE_7
{
	class Program
	{
		public static void Main()
		{
			// Solicitando nome do úsuario
			Console.WriteLine("Digite o seu nome:");
			string nomeUsuario = Console.ReadLine();
			
			// Solicitando idade do úsuario
			Console.WriteLine("Digite sua idade:");
			int idadeUsuario = int.Parse(Console.ReadLine());
			
			// Exibindo nome e idade do úsuario
			Console.WriteLine("O nome do úsuario é: " + nomeUsuario);
			Console.WriteLine("A idade do úsuario é: " + idadeUsuario);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
