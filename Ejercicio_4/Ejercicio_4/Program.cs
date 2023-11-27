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
            int numeroNotas;
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
            Console.ReadLine();
            
        }
    }
}
