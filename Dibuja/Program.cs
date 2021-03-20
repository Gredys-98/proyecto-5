using System;
using System.Threading;

namespace ejercio1
{

    class Program
    {
        public static void Dibuja(int cantidad)
        {
            int filas = 12;
            int columnas = 30;
            int filainterna = 2;
            int posicion = 2;
            int f, c, b;

            for (b = 1; b <= cantidad; b++)
            {
                for (f = posicion; f <= columnas; f++)
                {
                    Console.SetCursorPosition(f, filas); Console.Write("E");
                    Console.SetCursorPosition(f, filainterna); Console.Write("D");

                }
                for (c = filainterna; c <= filas; c++)
                {
                    Console.SetCursorPosition(posicion, c); Console.Write("C");
                    Console.SetCursorPosition(columnas, c); Console.Write("C");
                }
                filainterna++;
                filas--;
                posicion++;
                columnas--;
            }
            Console.WriteLine();
        }




        static void Main(string[] args)
        {
            for (int tamaño = 1; tamaño < 7; tamaño ++)//Este for da las instrucciones de cuantas veces tiene que dibujarse el marco
            {
                Dibuja(tamaño);//llamada a la funcion
                Thread.Sleep(1000);//velocidad a la que se imprimira cada marco


            }


            Console.WriteLine();
        }


    }
}

