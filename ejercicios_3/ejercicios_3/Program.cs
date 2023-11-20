using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_3
{
    internal class Program
    {
        static void writeGreen(int ejercicio)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ejercicio : " + ejercicio);
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
                            Console.Write(i + " ");
                            i = i - 20;
                        }
                        break;
                    case 6:
                        Console.Clear();
                        writeGreen(numEj);
                        int numeros = 0;
                        for (int a = numeros; a <= 100; a += 1)
                        {
                            if(a % 5 == 0 || a % 7 == 0)
                            {
                                Console.Write(a + " ");
                            }
                        }
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.Clear();
                        writeGreen(numEj);
                        int mult;
                        Console.WriteLine("Introduzca el número:");
                        mult = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"{mult} x 1 = {mult * 1}");
                        Console.WriteLine($"{mult} x 2 = {mult * 2}");
                        Console.WriteLine($"{mult} x 3 = {mult * 3}");
                        Console.WriteLine($"{mult} x 4 = {mult * 4}");
                        Console.WriteLine($"{mult} x 5 = {mult * 5}");
                        Console.WriteLine($"{mult} x 6 = {mult * 6}");
                        Console.WriteLine($"{mult} x 7 = {mult * 7}");
                        Console.WriteLine($"{mult} x 8 = {mult * 8}");
                        Console.WriteLine($"{mult} x 9 = {mult * 9}");
                        Console.WriteLine($"{mult} x 10 = {mult * 10}");
                        Console.ReadLine();
                        break;
                    case 8:
                        Console.Clear();
                        writeGreen(numEj);
                        float num;
                        Console.WriteLine("Introduzca el número:");
                        num = float.Parse(Console.ReadLine());
                        Console.Clear();
                        for(float b = num; b <= (num + 5); b += 1)
                        {
                            Console.WriteLine($"Número: {b}     Cuadrado: {Math.Pow(b , 2)}     Cubo: {Math.Pow(b , 3)}");
                        }
                        Console.ReadLine();
                        break;
                    case 9:
                        Console.Clear();
                        writeGreen(numEj);
                        Console.WriteLine("N            Raíz(n)");
                        for(float numer = 16f; numer >= 1; numer -= 2.5f)
                        {
                            Console.WriteLine($"{numer}            {Math.Sqrt(numer)}");
                        }
                        Console.ReadLine();
                        break;
                    case 10:
                        Console.Clear();
                        writeGreen(numEj);
                        float m;
                        Console.WriteLine("Introduzca un número positivo:");
                        m = float.Parse(Console.ReadLine());
                        Console.Clear();
                        while(m < 0)
                        {
                            Console.WriteLine("Este es un número negativo, introduzca un número positivo:");
                            m = float.Parse(Console.ReadLine());
                            Console.Clear();
                        }
                        float numeroTo = 0;
                        for(float c = 0; c <= (m); c += 1)
                        {
                            numeroTo += c;
                        }
                        Console.WriteLine($"La suma es: {numeroTo}.");
                        Console.ReadLine();
                        break;
                    case 11:
                        Console.Clear();
                        writeGreen(numEj);
                        float n;
                        Console.WriteLine("Introduzca el número:");
                        n = float.Parse(Console.ReadLine());
                        Console.Clear();
                        while(n < 0)
                        {
                            Console.WriteLine("Introduzca el número:");
                            n = float.Parse(Console.ReadLine());
                            Console.Clear();
                        }
                        float numeroT = 0;
                        for(float d = 1; d <= n; d += 1)
                        {
                            numeroT = numeroT + (float)(1 / (Math.Pow(d, 3)));
                        }
                        Console.WriteLine("La suma es: " + numeroT);
                        Console.ReadLine();
                        break;
                    case 12:
                        Console.Clear();
                        writeGreen(numEj);
                        int diviNum;
                        Console.WriteLine("Introduce un número positivo:");
                        diviNum = int.Parse(Console.ReadLine());
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("Este es un número negativo, introduzca un número positivo:");
                            diviNum = int.Parse(Console.ReadLine());
                            Console.Clear();
                        }
                        while(diviNum < 0);
                        int sumaDivisores = 0;
                        for(int f = 1; f <= diviNum; f++)
                        {
                            if(f % diviNum == 0)
                            {
                                sumaDivisores = sumaDivisores + f;
                            }
                            else
                            { }
                        }
                        Console.WriteLine("La suma de sus divisores es: " + sumaDivisores);
                        Console.ReadLine();
                        break;
                    case 13:
                        Console.Clear();
                        writeGreen(numEj);
                        int perfe;
                        Console.WriteLine("Introduzca el número:");
                        perfe = int.Parse(Console.ReadLine());
                        Console.Clear();
                        int NumePerf = 0;
                        for(int e = 1; e < perfe; e += 1)
                        {
                            if(e % perfe == 0)
                            {
                                NumePerf += e;
                            }
                            else
                            {
                            }
                        }
                        if(NumePerf == perfe)
                        {
                            Console.WriteLine("El número es perfecto.");
                        }
                        else
                        {
                            Console.WriteLine("El número no es perfecto.");
                        }
                        Console.ReadLine();
                        break;
                    case 14:
                        Console.Clear();
                        writeGreen(numEj);
                        int n1;
                        Console.WriteLine("Introuzca un número no negativo:");
                        n1 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("Este número es negativo, introduzca una positivo:");
                            n1 = int.Parse(Console.ReadLine());
                            Console.Clear();
                        }
                        while(n1 <= 0);
                        int sumaMultiplos5 = 0;
                        for(int contador = 0; contador <= n1; contador += 1)
                        {
                            int múltiplos5 = 1;
                            do
                            {
                                múltiplos5++;
                            }
                            while (múltiplos5 % 5 != 0);
                            sumaMultiplos5 = sumaMultiplos5 + múltiplos5;
                        }
                        Console.WriteLine("La suma es:" + sumaMultiplos5);
                        Console.ReadLine();
                        break;
                    case 15:
                        Console.Clear();
                        writeGreen(numEj);
                        int n2;
                        long factorial = 1;
                        Console.WriteLine("Introduzca el número para calcular su factorial:");
                        n2 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        for(int g = n2 - 1; g > 0; g--)
                        {
                            factorial = factorial * (n2 - g);
                        }
                        Console.WriteLine("el número factorial es: " + factorial);
                        Console.ReadLine();
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
