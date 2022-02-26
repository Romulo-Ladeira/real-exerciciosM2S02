using System;
using System.Collections.Generic;
using System.Linq;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Digite o {i}º numero");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            
            Console.WriteLine($"O maior numero que voce digtou foi {list.Max()}");
        }
    }
}
