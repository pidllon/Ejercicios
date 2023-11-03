using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Los números pares saldran en azul y los impares en blanco.");
            Console.WriteLine("Introduce el mínimo:");
            a = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Introduce el máximo(no incluido):");
            b = int.Parse(Console.ReadLine());
            Console.Clear();
            while(a < b)
            {
                if(a % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(a + " ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(a + " ");
                }
                a += 1;
            }
            Console.ReadLine();
        }
    }
}
