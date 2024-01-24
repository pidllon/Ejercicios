using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseSasha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicializar y dar valores a las variables
            int num1 = 14;
            int num2;
            int num3, num4, num5, num6;
            num2 = 7;
            /* Comandos:
             * [tipo de variable] [nombre de la variable], [nombre de la variable2];
             * [nombre variables] = [valor que queramos meter en la variable];
             */
            //escribir y leer en la consola
            Console.WriteLine("Hola mundo");
            Console.Write("hola ");
            Console.Write("abuela");
            Console.ReadLine();
            /* Comandos:
             * Console.WriteLine("Lo que queramos escribir");
             * Console.Write("Lo que queramos escribir");
             * Console.ReadLine();
             */
            Console.WriteLine("Variable num1: " + num1);
            Console.ReadLine();
            // Constantes
            const int david = 34;
            /* Lo mismo que una variable cambia en que su valor una vez que se define
             * ya no se puede cambiar su valor en el resto del código.
             * sintaxis:
             * const [tipo de valor] [nombre de la constante] = [Valor que le quieres meter];
             * los tipos de valores son los mismos que los de las variables es todo igual lo unico que 
             * cambia esque es un valor constante en el código.
             */
            // Guardar valores pedidos por teclado
            string nombre;
            int pin;
            Console.WriteLine("Intruzca su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Tu nombre es: " + nombre);
            Console.WriteLine("Introduzca su pin:");
            pin = int.Parse(Console.ReadLine());
            Console.WriteLine("Tu pin es: " + pin);
            Console.ReadLine();
            /* Comandos a recordar
             * [nombre variable] = console.readline(); (esto si es de tipo string la variable)
             * [nombre variable] = [tipo de valor].parse(console.readline()); (esto si la variable no es string)
             */
            Console.Clear();
            // Console.Clear(); es un metodo muy util para limpiar la consola y que tener todo más limpio y ordenado
        }
    }
}
