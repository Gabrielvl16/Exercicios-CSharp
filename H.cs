using System;

namespace ATIVIDADE_8
{
	class Program
	{
		public static void Main()
		{
			// Pedindo que o úsuario digite o valor do produto
			Console.WriteLine("Digite o preço do produto: ");
			double precoProduto = double.Parse(Console.ReadLine());
			
			// Pedindo que o úsuario digite o desconto do produto
			Console.WriteLine("Digite o desconto do produto:");
			double descontoProduto = double.Parse(Console.ReadLine());
			
			// Calculando desconto final
			double descontoFinal = (precoProduto * descontoProduto) / 100;
			
			// Calculando preço final
			double precoFinal = precoProduto - descontoFinal;
			
			// Exibindo preço final
			Console.WriteLine("O preço final com o desconto é: " + precoFinal);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
