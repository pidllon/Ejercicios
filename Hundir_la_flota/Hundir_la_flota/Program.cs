using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
                    int[,] ej46Original = { { 1, 0, 8 }, { 3, 5, 0 }, { 2, 9, 6 } };
                    int[,] ej46 = new int[3, 3];
                    for(int contador = 0; contador < ej46Original.GetLength(0); contador++)
                    {
                        for(int contador2 = 0; contador2 < ej46Original.GetLength(1); contador2++)
                        {
                            ej46[contador2, contador] = ej46Original[contador, contador2];
                        }
                    }
                    //A
                    float contadorValoresA = 0;
                    float contadorCeros = 0;
                    float porcentajeCeros = 0;
                    for (int contador = 0; contador < ej46.GetLength(0); contador++)
                    {
                        for (int contador2 = 0; contador2 < ej46.GetLength(1); contador2++)
                        {
                            contadorValoresA++;
                            if (ej46[contador, contador2] == 0)
                            {
                                contadorCeros++;
                            }
                        }
                    }
                    porcentajeCeros = contadorCeros / (contadorValoresA / 100);
                    Console.WriteLine("Hay un " +  porcentajeCeros + "% de ceros.");
                    //B
                    for (int contador = 0; contador < ej46Original.GetLength(0); contador++)
                    {
                        Console.WriteLine();
                        for (int contador2 = 0; contador2 < ej46Original.GetLength(1); contador2++)
                        {
                            Console.Write(ej46Original[contador, contador2] + " ");
                        }
                    }
                    Console.WriteLine();
                    for (int contador = 0; contador < ej46.GetLength(0); contador++)
                    {
                        Console.WriteLine();
                        for (int contador2 = 0; contador2 < ej46.GetLength(1); contador2++)
                        {
                            Console.Write(ej46[contador, contador2] + " ");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Son simetricos.");
                    //C
                    Console.WriteLine();
                    int sumaPrimeraFila = 0;
                    for(int contador = 0; contador < ej46.GetLength(1); contador++)
                    {
                        sumaPrimeraFila = sumaPrimeraFila + ej46[0, contador];
                    }
                    Console.WriteLine("La suma de la primera fila es: " + sumaPrimeraFila);
                    //D
                    Console.WriteLine();
                    int SumaÚltimaColumna = 0;
                    for (int contador = 0; contador < ej46.GetLength(0); contador++)
                    {
                        SumaÚltimaColumna = SumaÚltimaColumna + ej46[contador, 2];
                    }
                    Console.WriteLine("La suma de la última columna es: " + SumaÚltimaColumna);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ejercicio 55");
                    int[,] ej55 = new int[5, 5];
                    Random generador = new Random();
                    int numX1, numX2, numX3, numY1, numY2, numY3;
                    numX1 = generador.Next(0, 5);
                    numX2 = generador.Next(0, 5);
                    numX3 = generador.Next(0, 5);
                    numY1 = generador.Next(0, 5);
                    numY2 = generador.Next(0, 5);
                    numY3 = generador.Next(0, 5);
                    for(int contador = 0; contador < ej55.GetLength(0); contador++)
                    {
                        for(int contador2 = 0; contador2 < ej55.GetLength(1); contador2++)
                        {
                            int num = generador.Next(0, 10);
                            ej55[contador, contador2] = num;
                        }
                    }
                    ej55[numX1, numY1] = 0;
                    ej55[numX2, numY2] = 0;
                    ej55[numX3, numY3] = 0;
                    int x, y, vidas, cerosEncontrados;
                    vidas = 6;
                    cerosEncontrados = 0;
                    do
                    {
                        Console.WriteLine("Vidas: " + vidas);
                        Console.WriteLine("Ceros encontrados: " + cerosEncontrados);
                        Console.WriteLine("Introduzca la coordenada vertical:");
                        x = int.Parse(Console.ReadLine());
                        x--;
                        Console.WriteLine("Introduzca la coordenada horizontal:");
                        y = int.Parse(Console.ReadLine());
                        y--;
                        if (ej55[x, y] == 0)
                        {
                            Console.WriteLine("¡HABIA UN CERO!");
                            cerosEncontrados++;
                        }
                        else
                        {
                            Console.WriteLine("No habia ningún cero");
                            vidas--;
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }
                    while (vidas > 0 && cerosEncontrados < 3);
                    if(cerosEncontrados == 3)
                    {
                        Console.WriteLine("QUE BUENA HAS GANADO CRACK");
                    }
                    else
                    {
                        Console.WriteLine("PERDISTE");
                    }
                }
                Console.ReadLine();
            }
            else
            {
                //2x barcos 1 pixel 
                //3x barcos 2 pixeles 
                //3x barcos de 3 pixeles 
                //1x barcos de 4 pixeles 
                // 21 pixeles
                Console.Clear();
                Console.WriteLine("Hundir la flota");
                Console.WriteLine("2x barcos de 1 pixel");
                Console.WriteLine("3x barcos de 2 pixeles");
                Console.WriteLine("3x barcos de 3 pixeles");
                Console.WriteLine("1x barco de 4 pixeles");
                Console.ReadLine();
                string jugador1P, jugador2P;
                char[,] jugador1 = new char[10, 10];
                char[,] jugador1X = new char[10, 10];
                char[,] jugador2 = new char[10, 10];
                char[,] jugador2X = new char[10, 10];
                for(int contador = 0; contador < jugador1.GetLength(0); contador++)
                {
                    for(int contador2 = 0; contador2 < jugador1.GetLength(1); contador2++)
                    {
                        jugador1[contador, contador2] = 'M';
                    }
                }
                for (int contador = 0; contador < jugador1X.GetLength(0); contador++)
                {
                    for (int contador2 = 0; contador2 < jugador1X.GetLength(1); contador2++)
                    {
                        jugador1X[contador, contador2] = 'M';
                    }
                }
                for (int contador = 0; contador < jugador2.GetLength(0); contador++)
                {
                    for (int contador2 = 0; contador2 < jugador2.GetLength(1); contador2++)
                    {
                        jugador2[contador, contador2] = 'M';
                    }
                }
                for (int contador = 0; contador < jugador2X.GetLength(0); contador++)
                {
                    for (int contador2 = 0; contador2 < jugador2X.GetLength(1); contador2++)
                    {
                        jugador2X[contador, contador2] = 'M';
                    }
                }
                int x, y;
                Console.WriteLine("NOMBRE DEL JUGADOR 1:");
                jugador1P = Console.ReadLine();
                Console.WriteLine("NOMBRE DEL JUGADOR 2:");
                jugador2P = Console.ReadLine();
                Console.Clear();
                for(int pixeles = 21; pixeles > 0; pixeles--)
                {
                    Console.WriteLine("Turno de colocar barcos para " + jugador1P);
                    for (int contador = 0; contador < jugador1.GetLength(0); contador++)
                    {
                        Console.WriteLine();
                        for (int contador2 = 0; contador2 < jugador1.GetLength(1); contador2++)
                        {
                            Console.Write(jugador1[contador, contador2]);
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Pixeles restantes: " + pixeles);
                    Console.WriteLine("Introduzca la coordenada vertical:");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca la coordenada horizontal:");
                    y = int.Parse(Console.ReadLine());
                    x--;
                    y--;
                    jugador1[x, y] = 'B';
                    Console.Clear();
                }
                for (int pixeles = 21; pixeles > 0; pixeles--)
                {
                    Console.WriteLine("Turno de colocar barcos para " + jugador2P);
                    for (int contador = 0; contador < jugador2.GetLength(0); contador++)
                    {
                        Console.WriteLine();
                        for (int contador2 = 0; contador2 < jugador2.GetLength(1); contador2++)
                        {
                            Console.Write(jugador2[contador, contador2]);
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Pixeles restantes: " + pixeles);
                    Console.WriteLine("Introduzca la coordenada vertical:");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca la coordenada horizontal:");
                    y = int.Parse(Console.ReadLine());
                    x--;
                    y--;
                    jugador2[x, y] = 'B';
                    Console.Clear();
                }
                int jugada = 1;
                int pixelBarcoHundido1 = 0;
                int pixelBarcoHundido2 = 0;
                do
                {
                    if (jugada == 1)
                    {
                        jugada++;
                        Console.WriteLine("Turno de " + jugador1P);
                        Console.WriteLine("Tus barcos:");
                        for (int contador = 0; contador < jugador1.GetLength(0); contador++)
                        {
                            Console.WriteLine();
                            for (int contador2 = 0; contador2 < jugador1.GetLength(1); contador2++)
                            {
                                Console.Write(jugador1[contador, contador2]);
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Historial de disparos:");
                        for (int contador = 0; contador < jugador1X.GetLength(0); contador++)
                        {
                            Console.WriteLine();
                            for (int contador2 = 0; contador2 < jugador1X.GetLength(1); contador2++)
                            {
                                Console.Write(jugador1X[contador, contador2]);
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Coordenadas para atacar:");
                        Console.WriteLine("Introduzca la coordenada vertical:");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca la coordenada horizontal:");
                        y = int.Parse(Console.ReadLine());
                        if (jugador2[x, y] == 'B')
                        {
                            Console.WriteLine("TOCADO");
                            pixelBarcoHundido1++;
                            jugador1X[x, y] = 'B';
                            jugador2[x, y] = 'X';
                        }
                        else
                        {
                            Console.WriteLine("AGUA");
                            jugador1X[x, y] = 'X';
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        jugada--;
                        Console.WriteLine("Turno de " + jugador2P);
                        Console.WriteLine("Tus barcos:");
                        for (int contador = 0; contador < jugador2.GetLength(0); contador++)
                        {
                            Console.WriteLine();
                            for (int contador2 = 0; contador2 < jugador2.GetLength(1); contador2++)
                            {
                                Console.Write(jugador2[contador, contador2]);
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Historial de disparos:");
                        for (int contador = 0; contador < jugador2X.GetLength(0); contador++)
                        {
                            Console.WriteLine();
                            for (int contador2 = 0; contador2 < jugador2X.GetLength(1); contador2++)
                            {
                                Console.Write(jugador2X[contador, contador2]);
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Coordenadas para atacar:");
                        Console.WriteLine("Introduzca la coordenada vertical:");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca la coordenada horizontal:");
                        y = int.Parse(Console.ReadLine());
                        if (jugador1[x, y] == 'B')
                        {
                            Console.WriteLine("TOCADO");
                            pixelBarcoHundido2++;
                            jugador2X[x, y] = 'B';
                            jugador1[x, y] = 'X';
                        }
                        else
                        {
                            Console.WriteLine("AGUA");
                            jugador2X[x, y] = 'X';
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                while(pixelBarcoHundido1 < 21 && pixelBarcoHundido2 < 21);
                if(pixelBarcoHundido1 == 21)
                {
                    Console.WriteLine("¡Has Ganado " + jugador1P + "!");
                }
                else
                {
                    Console.WriteLine("¡Has Ganado " + jugador2P + "!");
                }
                Console.ReadLine();
            }
        }
    }
}
