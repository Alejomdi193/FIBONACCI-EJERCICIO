using System;

namespace Ejercicio2
{
    class Class
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Verificacion de numero Fibonacci");
            Console.WriteLine("\n");

            Console.Write("Ingrese un numero entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (True(numero))
            {
                Console.WriteLine($"{numero} es un numero de Fibonacci");
            }
            else
            {
                Console.WriteLine($"{numero} no es un numero de Fibonacci");
            }
        }

        static bool True(int numero)
        {
            if (numero < 0)
            {
                return false; 
            }

            int a = 0, b = 1;

            while (b < numero)
            {
                int c = a + b;
                a = b;
                b = c;
            }

            return b == numero;
        }
    }
}
