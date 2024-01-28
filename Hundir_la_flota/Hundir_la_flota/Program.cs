using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundir_la_flota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                       BIENVENIDO PULSE ENTER PARA CONTINUAR");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
            //linea----------------------
            string menuSelecciónTecla;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                       MENÚ DE SELECCIÓN:");
            Console.WriteLine("                                       Ejercicios introduzca 1");
            Console.WriteLine("                                       Hundir la flota introduzca 2");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            menuSelecciónTecla = Console.ReadLine();
            while(menuSelecciónTecla != "1" && menuSelecciónTecla != "2")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                                    ERROR, OPCIÓN NO ENCONTRADA VUELVA A INTRODUCIR UNA OPCIÓN.");
                Console.WriteLine("                                    MENÚ DE SELECCIÓN:");
                Console.WriteLine("                                    Ejercicios introduzca 1");
                Console.WriteLine("                                    Hundir la flota introduzca 2");
                menuSelecciónTecla = Console.ReadLine();
            }
            Console.Clear();
            string numEj;
            if(menuSelecciónTecla == "1")
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                                    INTRODUZCA EL NÚMERO DEL EJERCICIO QUE QUIERAS VER (44, 46, 55):");
                numEj = Console.ReadLine();
                while(numEj != "44" && numEj != "46" && numEj != "55")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                EJERCICIO NO ENCONTRADO, VUELVA A INTRODUCIR UNO (44, 46, 55):");
                    numEj = Console.ReadLine();
                }
                if(numEj == "44")
                {
                    Console.Clear();
                    Console.WriteLine("Ejercicio 44");
                    int numFila;
                    int[,] ej44 = { {5, 9, 2}, {4, 0, 3}, {1, 6, 8} };
                    //A
                    Console.WriteLine("Escoge una de las tres filas de la matriz e introduzcala:");
                    numFila = int.Parse(Console.ReadLine());
                    numFila--;
                    Console.Clear();
                    for(int contador = 0; contador < ej44.GetLength(1); contador++)
                    {
                        Console.Write(ej44[numFila, contador] + " ");
                    }
                    Console.ReadLine();
                    //B
                    for(int contador = 0; contador < ej44.GetLength(0); contador++)
                    {
                        ej44[contador, 2] = 0;
                    }
                    //C
                    Console.Clear();
                    int sumaValoresC = 0;
                    for(int contador = 0; contador < ej44.GetLength(1); contador++)
                    {
                        sumaValoresC = sumaValoresC + ej44[0, contador];
                    }
                    Console.WriteLine("La suma de la primera fila es: " + sumaValoresC);
                    //D
                    int contadorCerosD = 0;
                    for(int contador = 0; contador < ej44.GetLength(0); contador++)
                    {
                        if (ej44[contador, 1] == 0)
                        {
                            contadorCerosD++;
                        }
                    }
                    Console.WriteLine("Número de ceros en la segunda columna: " + contadorCerosD);
                    //E
                    float sumaE, mediaE, contadorNumeroPosiciones;
                    sumaE = 0;
                    contadorNumeroPosiciones = 0;
                    mediaE = 0;
                    for(int contador = 0; contador < ej44.GetLength(0); contador++)
                    {
                        for(int contador2 = 0; contador2 < ej44.GetLength(1); contador2++)
                        {
                            sumaE = sumaE + ej44[contador, contador2];
                            contadorNumeroPosiciones++;
                        }
                    }
                    mediaE = sumaE / contadorNumeroPosiciones;
                    Console.WriteLine($"La cuenta es: {sumaE} / {contadorNumeroPosiciones}");
                    Console.WriteLine("La media de la matriz es de: " + mediaE);
                }
                else if(numEj == "46")
                {
                    Console.Clear();
                    Console.WriteLine("Ejercicio 46");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ejercicio 55");
                }
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Hundir la flota");
                Console.ReadLine();
            }
        }
    }
}
