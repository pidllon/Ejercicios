using System;
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
            //programa que a partir del salario bruto de un trabajador aplica un irpf del 15% di el salario 
            // <= 1200€ y un irpf del 19 % si es superior
            float salarioBruto, irpf15, irpf19, salarioNeto;
            Console.WriteLine("introduzca el salario bruto:");
            salarioBruto = int.Parse(Console.ReadLine());
            Console.Clear();
            irpf15 = salarioBruto * 0.15f;
            irpf19 = salarioBruto * 0.19f;
            if (salarioBruto <= 1200)
            {
                salarioNeto = salarioBruto - irpf15;
            }
            else
            {
                salarioNeto = salarioBruto - irpf19;
            }
            Console.WriteLine("salario neto es " + salarioNeto);
            Console.ReadLine();

        }
    }
}
