using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_3
{
    internal class Program
    {
        static void writeGreen(int ejercicio)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ejercicio :" + ejercicio);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Main(string[] args)
        {
            /*int a, b;
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


            for(int i = 1; i <= 20; i = i + 1)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();*/

            //calcula la suma de los números entre n y m
            /*//como yo lo hice, lo que se puede mejorar es crear una variable i en vez de modificar directamente la n.
            int n1 = 15;
            int m1 = 30;
            int suma1;
            for(suma = 0; n1 <= m1; n1 += 1)
            {
                suma1 += n1;
            }
            Console.WriteLine(suma);
            Console.ReadLine();

            //calcula la suma de los números impares entre n y m
            int n = 15;
            int m = 30;
            int suma = 0;
            for(int i = n; i <= m; i++)
            {
                if(i % 2 != 0)
                {
                    suma = suma + i;
                }
            }
            Console.WriteLine(suma);
            Console.ReadLine();*/


            //aqui empieza el boletin
            string cont;
            Console.WriteLine("Quieres ver los ejercicios? Introduzca si, si es asi:");
            cont = Console.ReadLine();
            while (cont == "SI" || cont == "si" || cont == "Si" || cont == "sI")
            {
                int numEj;
                Console.WriteLine("Introduzca el número del ejercicio:");
                numEj = int.Parse(Console.ReadLine());
                switch (numEj)
                {
                    case 5:
                        Console.Clear();
                        writeGreen(numEj);
                        Console.WriteLine("Números del 320 al 160 de 20 en 20:");
                        int i = 320;
                        while (i >= 160)
                        {
                            Console.WriteLine(i + " ");
                            i = i - 20;
                        }
                        break;
                    case 6:

                        break;
                    default:
                        Console.WriteLine("Este ejercicio no existe en este boletín.");
                        break;
                }
                Console.WriteLine("Quieres continuar, introduzca si para ello, si no quiere continuar pulse enter:");
                cont = Console.ReadLine();
            }
        }
    }
}
