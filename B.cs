using System;

namespace ATIVIDADE_2
{
	class Program
	{
		public static void Main()
		{
			// Solicita que o úsuario digite um número real
			Console.WriteLine("Digite um número real:");
			
			// Lê oque o úsuario digitou
			double numeroReal = double.Parse(Console.ReadLine());
			
			// Imprime o número digitado
			Console.WriteLine("O número digitado foi: " + numeroReal);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
