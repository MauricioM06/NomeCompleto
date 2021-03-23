using System;

namespace Nome
{

    public class Program 
    {
        public static void Main(string [] args)
        {
			Console.WriteLine("Digite seu primeiro nome:");
			string Nome = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("Digite seu sobrenome:");
			string Sobrenome = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("Nome Completo: " + Nome + " " + Sobrenome);
			Console.WriteLine("Nome de catálogo: " + Sobrenome.ToUpper() + ", " + Nome);
        }
    }
}