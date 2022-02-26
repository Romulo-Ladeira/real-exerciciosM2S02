using System;
using System.Collections.Generic;

namespace exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            var lados = new List<int>();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Digite o tamanho do {i}º lado");
                lados.Add(Convert.ToInt32(Console.ReadLine()));
            }
            lados.Sort();

            if (lados[0] + lados[1] > lados[2])
            {
                if (lados[0] == lados[1] && lados[1] == lados[2])
                {
                    Console.WriteLine("Esse Triangulo é equilátero");
                }
                else if (lados[0] == lados[1] || lados[0] == lados[2] || lados[1] == lados[2])
                {
                    Console.WriteLine("Esse Triangulo é Isóceles");
                }
                else
                {
                    Console.WriteLine("Esse Triangulo é Escaleno");
                }
            }
            else
            {
                Console.WriteLine("não é triangulo");
            }
        }
    }
}
