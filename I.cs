using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que digite uma palavra
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine(); 

        // Exibe o comprimento da palavra
        Console.WriteLine("O comprimento da palavra é: " + palavra.Length);
        
	Console.Write("Press any key to continue . . . ");
	Console.ReadKey(true);
    }
}
