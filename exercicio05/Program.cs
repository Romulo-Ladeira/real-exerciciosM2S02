using System;
using System.Collections.Generic;
using System.Linq;

namespace exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Digite o {i}º numero");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            list.Sort();
            list.Reverse();

            Console.WriteLine();

            list.ForEach(Console.WriteLine); ;
        }
    }
}
