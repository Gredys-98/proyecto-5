using System;


namespace ejercicio3
{
    class Program
    {
        public static string GeneraLetra()
        {
            Random ran = new Random();//genera numeros aleatorios 
            int NUMERO = Convert.ToInt32(ran.Next(97, 106));// busqueda  de  rango de numeros
            string respuesta = "no hay";// si sobrepasa el rango imprima la respuesta

          

            if ((NUMERO > 96) & (NUMERO < 107))// condicion de numeros 
            {
                respuesta = Convert.ToString((char)NUMERO);//sustrae una cadena de caracteres

            }
            return respuesta;
        }


        static void Main(string[] args)
        {
            byte tamaño, s;
            
            string numeros;
            Console.WriteLine("Cuantos Numeros");
            numeros = Console.ReadLine();
             tamaño = byte.Parse(numeros);// convierte una cadena a entero
            string Letras = " ";


            for (s = 1; s <= tamaño; s++)
            {
                Letras = GeneraLetra();
                Console.WriteLine($"el codigo {Letras}");

            }
        }
    }
}
