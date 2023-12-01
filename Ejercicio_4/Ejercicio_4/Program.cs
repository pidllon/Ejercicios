using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejemplos fuera de los ejercicios del boletín
            /*int numeroNotas;
            Console.WriteLine("Introduzca el número de notas que vas a introducir:");
            numeroNotas = int.Parse(Console.ReadLine());
            float[] notas = new float[numeroNotas];
            int i = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Introduzca una nota:");
                notas[i] = int.Parse(Console.ReadLine());
                i++;
            }
            while (i < numeroNotas);
            float media = 0f;
            float suma = 0;
            for(i = 0; i < numeroNotas; i++)
            {
                suma = suma + notas[i];
            }
            Console.Clear();
            media = suma / numeroNotas;
            Console.WriteLine("La media: " + media);
            Console.ReadLine();*/


            string si;
            Console.WriteLine("Quieres ver los ejercicios, introduzca si para verlos o pulse enter para salirte.");
            si = Console.ReadLine();
            do
            {
                Console.Clear();
                int numEj;
                Console.WriteLine("INTRODUZCA EL NÚMERO DEL EJERCICIO:");
                numEj = int.Parse(Console.ReadLine());
                Console.Clear();
                while (numEj < 7 || numEj > 43)
                {
                    Console.WriteLine("El ejercicio introducido no existe en este boletín, por favor vuelva a introducir otro:");
                    numEj = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                if (numEj == 7)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ejercicio " + numEj);
                    Console.ForegroundColor = ConsoleColor.White;
                    int n;
                    Console.WriteLine("Introduzca el número de valores a almacenar:");
                    n = int.Parse(Console.ReadLine());
                    int[] valoresInt = new int[n];
                    Console.WriteLine("Introduce el primer valor:");
                    valoresInt[0] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca el último valor:");
                    valoresInt[(n - 1)] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Primer valor:" + valoresInt[0] + "   Último valor:" + valoresInt[(n - 1)]);
                    Console.ReadLine();

                }
                else if (numEj == 8)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ejercicio " + numEj);
                    Console.ForegroundColor = ConsoleColor.White;
                    int[] valores100 = new int[100];
                    Random generador = new Random();
                    for (int contador = 0; contador < 100; contador++)
                    {
                        int num = generador.Next(0, 10);
                        valores100[contador] = num;
                    }
                    Console.Write(valores100[1] + ", " + valores100[4] + ", " + valores100[8]);
                    Console.ReadLine();
                }
                else if (numEj == 9)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ejercicio " + numEj);
                    Console.ForegroundColor = ConsoleColor.White;
                    int[] valores100Pares = new int[100];
                    int n = 1;
                    for (int contador = 0; contador < 100; contador++)
                    {
                        if (contador % 2 == 0)
                        {
                            valores100Pares[contador] = n;
                            n++;
                            Console.Write(contador + ": " + valores100Pares[contador] + " ");
                        }
                    }
                    Console.ReadLine();
                }
                else if(numEj == 10)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ejercicio " + numEj);
                    Console.ForegroundColor = ConsoleColor.White;
                    int[] valores100Impares = new int[100];
                    Random generador = new Random();
                    for(int contador = 0; contador < 100; contador++)
                    {
                        if(contador % 2 != 0)
                        {
                            int num = generador.Next(10, 35);
                            valores100Impares[contador] = num;
                            Console.Write(contador + ": " + valores100Impares[contador] + " ");
                        }
                    }
                    Console.ReadLine();
                }
                Console.WriteLine("Quieres volver a ver los ejercicios, introduzca si para ello, si no pulse enter:");
                si = Console.ReadLine();
            }
            while (si == "Si" || si == "SI" || si == "si" || si == "sI");
        }
    }
}
