using System;
using System.Linq;

namespace exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um frase");
            var frase = Console.ReadLine();

            string textoInvertido = new string(frase.Reverse().ToArray());

            Console.WriteLine($"O texto inverdido é: { textoInvertido}");
        }
    }
}
