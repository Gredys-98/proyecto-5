using System;
using System.Threading;

namespace Ejemplo2
{
    class Program
    {

        public static string Mid(string parametro, int starIndex, int Length)//Funcion Mid que acepta tres parametros 
                                                     //Devuelve una cadena que contiene todos los caracteres a partir de la posición especificada de una cadena
        {
            string result = parametro.Substring(starIndex, Length);//devuelve los caracteres extraidos de una cadena  linea por linea
            //substring = sustrae una cadena
            // starindex = muestra de donde va iniciar a mostrar cadena
            // length = obtine los carateres

            return result; // imprime el resultado

        }

        static void Main(string[] args)
        {
            string Nombre;
            string Caracter;
            int rotacion=0;
            int Inicio =0;
            int tamañoCadena = 0;
            int final = 0;
            Console.Write("Ingrese su nombre: ");//Se le pide al usuario su nombre
            Nombre = Console.ReadLine();//Se lee el nombre y se guarda en la variable Nombre
            Console.SetCursorPosition(1, 12);//se le asigna un lugar al cursor para la impresion
            Console.Write(Nombre);//imprime el nombre antes de iniciar la animacion

            tamañoCadena = Nombre.Length;// se le asigna como valor la cantidad de caracteres que hayan
            final = 70;//Con esta variable indicamos la posicion en que quedar en realcion horizontal
            Nombre = Nombre.ToUpper();//Transformar de minusculas a mayusculas

            for (Inicio = Nombre.Length; Inicio >= 1; Inicio--)//controla los caracteres que se van imprimiendo
            {
                Caracter = Mid(Nombre, Inicio - 1, 1);//Enviandole parametros a la funcion


                for (rotacion = tamañoCadena; rotacion <= final; rotacion++)//Este ciclo controla las posiciones donde se imprime cada letra
                {
                    Console.SetCursorPosition(rotacion, 12);//Ubica la impresion en un area determinada(vertical)
                    Console.Write(" " + Caracter);//Imprime las letras
                    Thread.Sleep(10);//Controla la velociad del desplazamiento

                }

                final--;// controla que los caracteres no se incrementen y que se coloquen en  pocicion actual convertidos a mayusculas
                tamañoCadena--;// controla que la caracteres tengan movimeinto
            }

            Console.WriteLine();

        }
    }
}
