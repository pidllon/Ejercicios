﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //boletín 4 
            //ejercicio 4
            float nota1, nota2, nota3, media;
            Console.WriteLine("Introduzca la 1ª nota:");
            nota1 = float.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Introduzca la 2ª nota:");
            nota2 = float.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Introduzca la 3ª nota:");
            nota3 = float.Parse(Console.ReadLine());
            Console.Clear();
            media = (nota1 + nota2 + nota3) / 3;
            if(media > 5)
            { Console.WriteLine("Alumno aprobado"); }
            else { Console.WriteLine("Alumno suspenso"); }
            Console.ReadLine();

            //ejercicio 5
            double num1, num2, suma;
            Console.WriteLine("introduzca el primer número real:");
            num1 = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("introduzca el segundo número real:");
            num2 = double.Parse(Console.ReadLine());
            Console.Clear();
            suma = num1 + num2;
            if(suma > 0) { Console.WriteLine(Math.Sqrt(suma)); }
            else { Console.WriteLine("no se puede hacer la raíz."); }
            Console.ReadLine();

            //ejercicio 6
            string contraseña1, contraseña2;
            contraseña1 = "pepe";
            Console.WriteLine("Introduzca la contraseña: ");
            contraseña2 = Console.ReadLine();
            Console.Clear();
            if(contraseña2 == contraseña1) { Console.WriteLine("contraseña correcta."); }
            else { Console.WriteLine("contraseña incorrecta."); }
            Console.ReadLine();

            //ejercicio 7
            double nume1, nume2;
            Console.WriteLine("a continuación se calculara con el número más grande elevado al número más pequeño");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Introduzca el primer número:");
            nume1 = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Introduzca el segundo número:");
            nume2 = double.Parse(Console.ReadLine());
            Console.Clear();
            if( nume1 > nume2) { Console.WriteLine(Math.Pow(nume1, nume2)); }
            else { Console.WriteLine(Math.Pow(nume2, nume1));}
            Console.ReadLine();

            //ejercicio 8
            double presion, temperatura;
            Console.WriteLine("introduzca la presion en atmósferas:");
            presion = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("introduzca la temperatura en Kelvin:");
            temperatura = double.Parse(Console.ReadLine());
            Console.Clear();
            if((presion > 2) && (temperatura > 500)) { Console.WriteLine("Abrir valvula de seguridad y bajar temperatura"); }
            else if(presion > 2) { Console.WriteLine("abrir valvula de seguridad"); }
            else if(temperatura > 500) { Console.WriteLine("bajar temperatura"); }
            else { Console.WriteLine("Todo en orden"); }
            Console.ReadLine();
        }
    }
}
