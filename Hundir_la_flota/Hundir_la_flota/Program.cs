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
