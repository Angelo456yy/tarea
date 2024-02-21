using System;

namespace HolaQueTal
{
    class Sentencial
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero: ");
            int numeroEntero = int.Parse(Console.ReadLine());

            if (numeroEntero == 7)
            {
                Console.WriteLine("El número entero es 7.");
            }
            else if (numeroEntero < 0)
            {
                Console.WriteLine("El número entero es negativo.");
            }
            else
            {
                Console.WriteLine("El número entero no es 7 ni negativo.");
            }
        }
    }
}
