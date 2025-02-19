using System;

namespace ATIVIDADE_1
{
	class Program
	{
		public static void Main()
		{
			// Solicita que o usuario digite um número inteiro
			Console.WriteLine("Digite um valor inteiro:");
			
			// Lê o número que o úsuario digitou 
			int numeroInteiro = int.Parse(Console.ReadLine());
			
			// Exibe o número que o úsuario digitou
			Console.WriteLine("O número digitado foi: " + numeroInteiro);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
