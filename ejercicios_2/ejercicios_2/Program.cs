using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //boletin 4

            int numEj;
            Console.WriteLine("Introduzca el número del ejercicio que desea revisar:");
            numEj = int.Parse(Console.ReadLine());
            Console.Clear();

            if (numEj == 4)
            {//ejercicio 4
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
                if (media > 5)
                {
                    Console.WriteLine("Alumno aprobado");
                }
                else
                {
                    Console.WriteLine("Alumno suspenso");
                }
                Console.ReadLine(); }

            if (numEj == 5)
            {//ejercicio 5
                double num1, num2, suma;
                Console.WriteLine("introduzca el primer número real:");
                num1 = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("introduzca el segundo número real:");
                num2 = double.Parse(Console.ReadLine());
                Console.Clear();
                suma = num1 + num2;
                if (suma > 0)
                {
                    Console.WriteLine(Math.Sqrt(suma));
                }
                else
                {
                    Console.WriteLine("no se puede hacer la raíz.");
                }
                Console.ReadLine(); }


            if (numEj == 6)
            {//ejercicio 6
                string contraseña1, contraseña2;
                contraseña1 = "pepe";
                Console.WriteLine("Introduzca la contraseña: ");
                contraseña2 = Console.ReadLine();
                Console.Clear();
                if (contraseña2 == contraseña1)
                {
                    Console.WriteLine("contraseña correcta.");
                }
                else
                {
                    Console.WriteLine("contraseña incorrecta.");
                }
                Console.ReadLine(); }


            if (numEj == 7)
            {//ejercicio 7
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
                if (nume1 > nume2)
                {
                    Console.WriteLine(Math.Pow(nume1, nume2));
                }
                else
                {
                    Console.WriteLine(Math.Pow(nume2, nume1));
                }
                Console.ReadLine(); }


            if (numEj == 8)
            {//ejercicio 8
                double presion, temperatura;
                Console.WriteLine("introduzca la presion en atmósferas:");
                presion = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("introduzca la temperatura en Kelvin:");
                temperatura = double.Parse(Console.ReadLine());
                Console.Clear();
                if ((presion > 2) && (temperatura > 500))
                {
                    Console.WriteLine("Abrir valvula de seguridad y bajar temperatura");
                }
                else if (presion > 2)
                {
                    Console.WriteLine("abrir valvula de seguridad");
                }
                else if (temperatura > 500)
                {
                    Console.WriteLine("bajar temperatura");
                }
                else
                {
                    Console.WriteLine("Todo en orden");
                }
                Console.ReadLine(); }


            if (numEj == 9)
            {//ejercicio 9
                double numer1;
                Console.WriteLine("introduzca un número:");
                numer1 = double.Parse(Console.ReadLine());
                Console.Clear();
                if ((numer1 % 2 == 0) || (numer1 % 3 == 0))
                {
                    Console.WriteLine("El número es multiplo de 3 y/o de 2");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine();
                }
            }


            if (numEj == 10)
            {//ejercicio 10
                float precio, reb1, reb2;
                Console.WriteLine("Introduzca el precio del producto:");
                precio = float.Parse(Console.ReadLine());
                Console.Clear();
                reb1 = precio * 0.10f;
                reb2 = precio * 0.15f;
                if (precio < 100)
                {
                    Console.WriteLine("Precio con rebaja: " + (precio - reb1));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Precio con rebaja: " + (precio - reb2));
                    Console.ReadLine();
                }
            }
            if (numEj == 11)
            {//ejercicio 11
                float nota;
                Console.WriteLine("Introduzca la nota: ");
                nota = float.Parse(Console.ReadLine());
                Console.Clear();
                if ((nota < 5) && (nota >= 0))
                {
                    Console.WriteLine("Suspenso");
                    Console.ReadLine();
                }
                else if ((nota >= 5) && (nota < 6.5))
                {
                    Console.WriteLine("Aprobado");
                    Console.ReadLine();
                }
                else if ((nota >= 6.5) && (nota < 8.5))
                {
                    Console.WriteLine("Notable");
                    Console.ReadLine();
                }
                else if ((nota >= 8.5) && (nota <= 10))
                {
                    Console.WriteLine("Sobresaliente");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("error en nota");
                    Console.ReadLine();
                }
            }


            if (numEj == 12)
            {//ejercicio 12
                float numero;
                Console.WriteLine("Introduzca el número:");
                numero = float.Parse(Console.ReadLine());
                Console.Clear();
                if((numero % 4 == 0) && (numero % 5 == 0))
                {
                    Console.WriteLine($"el número es multiplo de 5 y de 4 asi que primero hacemos la suma de 25: {numero + 25} Y ahora hacemos la suma pero con 50: {numero + 50}");
                    Console.ReadLine();
                }
                else if(numero % 4 == 0)
                {
                    Console.WriteLine($"el número es multiplo de 4, por lo que le sumamos 25: {numero + 25}");
                    Console.ReadLine();
                }
                else if (numero % 5 == 0)
                {
                    Console.WriteLine($"el número es multiplo de 5, por lo que le sumamos 50: {numero + 50}");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"el número no es múltiplo de ninguno por lo que se le suma 100: {numero + 100}");
                    Console.ReadLine();
                }
            }


            if (numEj == 13)
            {//ejercicio 13
                float temp;
                Console.WriteLine("Introduzca la temperatura:");
                temp = float.Parse(Console.ReadLine());
                Console.Clear();
                if (temp < 0)
                {
                    Console.WriteLine("SÓLIDO");
                    Console.ReadLine();
                }
                else if ((temp >= 0) && (temp <= 100))
                {
                    Console.WriteLine("LÍQUIDO");
                    Console.ReadLine();
                }
                else if ((temp > 100) && (temp <= 1000000))
                {
                    Console.WriteLine("VAPOR");
                    Console.ReadLine();
                }
                else if (temp > 1000000)
                {
                    Console.WriteLine("PLASMA");
                    Console.ReadLine();
                }
            }

            if (numEj == 14)
            {//ejercicio 14
                string letra;
                double numero1, numero2;
                Console.WriteLine("Elija una de las opciones escribiendo la tecla correspondiente a cada una:");
                Console.WriteLine("a - sumar");
                Console.WriteLine("b - restar");
                Console.WriteLine("c - multiplicar");
                Console.WriteLine("d - dividir");
                Console.WriteLine("e - raiz de la suma");
                letra = Console.ReadLine();
                if (letra == "a")
                {
                    Console.Clear();
                    Console.WriteLine("SUMA");
                    Console.WriteLine("Introduzca el primer número:");
                    numero1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca el segundo número:");
                    numero2 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine($"la suma de {numero1} + {numero2} es igual a {numero1 + numero2}.");
                    Console.ReadLine();

                }
                if (letra == "b")
                {
                    Console.Clear();
                    Console.WriteLine("RESTA");
                    Console.WriteLine("Introduzca el primer número:");
                    numero1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca el segundo número:");
                    numero2 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine($"la resta de {numero1} - {numero2} es igual a {numero1 - numero2}.");
                    Console.ReadLine();
                }
                if (letra == "c")
                {
                    Console.Clear();
                    Console.WriteLine("MULTIPLICAR");
                    Console.WriteLine("Introduzca el primer número:");
                    numero1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca el segundo número:");
                    numero2 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine($"la multiplicación de {numero1} x {numero2} es igual a {numero1 * numero2}.");
                    Console.ReadLine();
                }
                if (letra == "d")
                {
                    Console.Clear();
                    Console.WriteLine("DIVISIÓN");
                    Console.WriteLine("Introduzca el primer número:");
                    numero1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca el segundo número:");
                    numero2 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine($"la división de {numero1} / {numero2} es igual a {numero1 / numero2}.");
                    Console.ReadLine();
                }
                
                if (letra == "e")
                {
                    Console.Clear();
                    Console.WriteLine("RAÍZ DE LA SUMA");
                    Console.WriteLine("Introduzca el primer número:");
                    numero1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca el segundo número:");
                    numero2 = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine($"La raíz cuadrada de la suma de estos dos números es: {Math.Sqrt(numero1 + numero2)}");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("That command doesn´t exist.");
                }
            }

            //ejercicio 15
            float numLitros;
            Console.WriteLine("Introduzca el número de litros");
            numLitros = float.Parse(Console.ReadLine());
            Console.Clear();
            if(numLitros <= 50)
            {
                Console.WriteLine("Estas de suerte los primeros 50 litro son gratis, asi que no tienes que pagar nada!");
                Console.ReadLine();
            }
            else if((numLitros > 50) && (numLitros <= 200))
            {
                Console.WriteLine("pago con tarifa de 4,75 euros.");
                Console.ReadLine();
                float pago = (numLitros - 50) * 4.75f;
                if (pago > 45)
                {
                    Console.WriteLine($"Tiene que pagar {pago} euros.");
                    Console.ReadLine();
                }
                else if(pago <= 45)
                {
                    Console.WriteLine("Tiene que pagar 45 euros.");
                }
            }
            else if(numLitros > 200)
            {
                Console.WriteLine("pago con tarifa de 20 euros y por debajo de los 200 con tarifa de 4.75 euros.");
            }
        }
    }
}
