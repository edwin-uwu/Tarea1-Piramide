using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nv = 1;
            Console.WriteLine("¿Cuantas veces quiere repetir el ciclo?");
            nv = int.Parse(Console.ReadLine());
            for (int a1 = 1; a1 <= nv; a1++)
            {
                for (int a2 = 1; a2 <= a1; a2++)
                {

                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
