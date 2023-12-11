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
                else if(numEj == 16)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ejercicio " + numEj);
                    Console.ForegroundColor = ConsoleColor.White;
                    int n;
                    Console.WriteLine("Introduzca el número de valores a almacenar:");
                    n = int.Parse(Console.ReadLine());
                    int[] ej16 = new int[n];
                    int contador1 = 0;
                    Random generador = new Random();
                    for(int contador = 0; contador < n; contador++)
                    {
                        int num = generador.Next(-5, 5);
                        ej16[contador] = num;
                    }
                    for(int contador2 = 0; contador2 < n; contador2++)
                    {
                        if(ej16[contador2] < 0)
                        {
                            contador1++;
                        }
                    }
                    Console.WriteLine("Números negativos: " + contador1);
                }
                else if(numEj == 14)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ejercicio " + numEj);
                    Console.ForegroundColor = ConsoleColor.White;
                    int[] ej14 = new int[10];
                    Random generador14 = new Random();
                    for(int i = 0; i < 10; i++)
                    {
                        int numAleatorio = generador14.Next(0, 11);
                        ej14[i] = numAleatorio;
                    }
                    int suma = 0;
                    for(int a = 0; a < ej14.Length; a++)
                    {
                        suma = suma + (int)(Math.Pow(ej14[a], 2));
                    }
                    Console.WriteLine("Esta es la suma de los cuadrados de los valores del array: " + suma);
                    Console.ReadLine();
                }
                else if(numEj == 15)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ejercicio " + numEj);
                    Console.ForegroundColor = ConsoleColor.White;
                    int[] ej15 = new int[10];
                    Random generador15 = new Random();
                    for(int i = 0; i < 10; i++)
                    {
                        int num15 = generador15.Next(-5, 6);
                        ej15[i] = num15;
                    }
                    int suma15 = 0;
                    for(int a = 0; a < ej15.Length; a++)
                    {
                        if (ej15[a] >= 0)
                        {
                            suma15 = suma15 + ej15[a];
                        }
                    }
                    Console.WriteLine("La suma de los valores no negativos es: " + suma15);
                    Console.ReadLine();
                }
                else if(numEj == 17)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ejercicio " + numEj);
                    Console.ForegroundColor = ConsoleColor.White;
                    int[] ej17 = new int[20];
                    Random generador17 = new Random();
                    for(int i = 0; i < 20; i++)
                    {
                        int num17 = generador17.Next(0, 20);
                        ej17[i] = num17;
                    }
                    int contador17 = 0;
                    int contador171 = 0;
                    int porcentajeImpares;
                    for(int a = 0; a < ej17.Length; a++)
                    {
                        contador171++;
                        if (ej17[a] % 2 != 0)
                        {
                            contador17++;
                        }
                    }
                    porcentajeImpares = (contador17 * 100) / contador171;
                    Console.WriteLine("El porcentaje de números impares es: " + porcentajeImpares + "%");
                    Console.ReadLine();
                }
                else if(numEj == 26)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ejercicio " + numEj);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Introduzca el número de valores del 1º array:");
                    int num26 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca el número de valores del 2º array:");
                    int num261 = int.Parse(Console.ReadLine());
                    int[] ej26 = new int[num26];
                    int[] ej261 = new int[num261];
                    int contador = 0;
                    int contador1 = 0;
                    for(int i = 0; i < ej26.Length; i++)
                    {
                        Console.Clear();
                        contador++;
                        Console.WriteLine("1º array:");
                        Console.WriteLine("Introduzca el valor: " + i);
                        int num262 = int.Parse(Console.ReadLine());
                        ej26[i] = num262;
                    }
                    for(int a = 0; a < ej261.Length; a++)
                    {
                        Console.Clear();
                        contador1++;
                        Console.WriteLine("2º array:");
                        Console.WriteLine("Introduzca el valor: " + a);
                        int num263 = int.Parse(Console.ReadLine());
                        ej261[a] = num263;
                    }
                    bool comparador = false;
                    if(contador == contador1)
                    {
                        for(int i = 0; i < ej261.Length; i++)
                        {
                            if (ej26[i] != ej261[i])
                            {
                                comparador = false;
                                break;
                            }
                            else
                            {
                                comparador = true;
                            }
                        }
                        if(comparador == true)
                        {
                            Console.WriteLine("Son iguales.");
                        }
                        else
                        {
                            Console.WriteLine("Son diferentes.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Son diferentes.");
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
