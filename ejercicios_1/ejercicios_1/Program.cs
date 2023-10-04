using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ejercicio 4
            double pi, radio, longitud, area, volumen;
            Console.WriteLine("introduzca la medida del radio del circulo en cm: ");
            radio = double.Parse(Console.ReadLine());
            pi = 3.141516;
            longitud = 2 * pi * radio;
            area = pi * (radio * radio);
            volumen = (4d / 3) * pi * (radio * radio * radio);
            Console.WriteLine("Longitud: " + longitud + "cm.");
            Console.WriteLine("Área: " + area + "cm cuadrados.");
            Console.WriteLine("Volumen: " + volumen + "cm cúbicos");
            Console.ReadLine();

            //ejercicio 5
            float precio, cantidad, importe;
            Console.WriteLine("introduzca el precio del producto: ");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("introduzca la cantidad del producto: ");
            cantidad = float.Parse(Console.ReadLine());
            importe = cantidad * precio;
            Console.WriteLine("El precio del producto es " + precio + " euros y la cantidad que compra es " + cantidad + " por lo tanto debe pagar " + importe + " euros. Vuelva pronto.");
            Console.ReadLine();

            //ejercicio 6
            float num1, num2, suma, resta, multiplicación;
            Console.WriteLine("introduzca el primer número: ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("introduzca el segundo número: ");
            num2 = float.Parse(Console.ReadLine());
            suma = num1 + num2;
            resta = num1 - num2;
            multiplicación = num1 * num2;
            Console.WriteLine("suma: " + suma);
            Console.WriteLine("resta: " + resta);
            Console.WriteLine("multiplicación: " + multiplicación);
            Console.ReadLine();

            //ejercicio 7
            float celsius, farenjin;
            Console.WriteLine("introduzca los grados en celsius: ");
            celsius = float.Parse(Console.ReadLine());
            farenjin = celsius * (9f / 5) + 32;
            Console.WriteLine("Son " + farenjin + " grados fahrenheit.");
            Console.ReadLine();

            //ejercicio 8
            double p, v, n, r, t;
            r = 0.082;
            Console.WriteLine("introduzca el volumen en litros:");
            v = double.Parse(Console.ReadLine());
            Console.WriteLine("introduzca el número de moles:");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine("introduzca la temperatura en Kelvin:");
            t = double.Parse(Console.ReadLine());
            p = (n * r * t) / v;
            Console.WriteLine("Con un volumen de " + v + " litros, y una temperatura de " + t + " Kelvin, " + n + " moles de un gas ideal tienen una presión de " + p + " atmósferas.");
            Console.ReadLine();

            //calculadora de porcentajes
            float precio1, porcentaje, resultado1;
            Console.WriteLine("Bienveido a la calculadora de porcentajes.");
            Console.WriteLine("introduzca el numero al que deseas saber un porcentaje: ");
            precio1 = float.Parse(Console.ReadLine());
            Console.WriteLine("introduzca el porcentaje en decimales, ejemplo: 15% = 0,15.");
            porcentaje = float.Parse(Console.ReadLine());
            resultado1 = precio1 * porcentaje;
            Console.WriteLine("El resultado es: " + resultado1);
            Console.ReadLine();

            //ejercicio 9
            object x, y;
            x = "paco";
            y = 33;


            //ejercicio 10

            float horas, tasa, salarioBruto, irpf, salarioNeto;
            Console.WriteLine("introduzca horas trabajadas: ");
            horas = float.Parse(Console.ReadLine());
            Console.WriteLine("introduzca la tasa: ");
            tasa = float.Parse(Console.ReadLine());
            Console.WriteLine("que IRPF desea aplicar: ");
            irpf = float.Parse(Console.ReadLine());
            salarioBruto = horas * tasa;
            salarioNeto = salarioBruto - (irpf * salarioBruto) / 100;
            Console.WriteLine("salario bruto: " + salarioBruto);
            Console.WriteLine("salario neto: " + salarioNeto);
            Console.ReadLine();

            //ejercicio 11
            double espacio, tiempo, velocidad;
            Console.WriteLine("Introduzca la distancia en metros:");
            espacio = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Introduzca el tiempo en segundos:");
            tiempo = double.Parse(Console.ReadLine());
            Console.Clear();
            velocidad = espacio / tiempo;
            Console.WriteLine("La velocidad es de " + velocidad + " metros/segundo.");
            Console.ReadLine();

            //ejercicio 12
            double lado, area1, perimetro, diagonal;
            Console.WriteLine("introduzca la longitud del lado en cm:");
            lado = double.Parse(Console.ReadLine());
            Console.Clear();
            area1 = Math.Pow(lado, 2);
            diagonal = lado * Math.Sqrt(2);
            perimetro = lado * 4;
            Console.WriteLine("área: " + area1 + "cm cuadrados.");
            Console.WriteLine("diagonal: " + diagonal + "cm.");
            Console.WriteLine("perímetro: " + perimetro + "cm.");
            Console.ReadLine();

            //ejercicio 13
            float catetoA, catetoB, hipotenusa;
            Console.WriteLine("Introduzca el cateto A:");
            catetoA = float.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Introduzca el cateto B:");
            catetoB = float.Parse(Console.ReadLine());
            Console.Clear();
            hipotenusa = (float)(Math.Sqrt((Math.Pow(catetoA, 2)) + (Math.Pow(catetoB, 2))));
            Console.WriteLine("La hipotenusa es: " + hipotenusa);
            Console.ReadLine();


        }
    }
}
