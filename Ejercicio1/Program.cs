namespace Ejercicio1
{
    class Class
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Ejercicio Fibonacci");
            Console.WriteLine("\n");

            Console.Write("Ingrese un numero entero: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 1)
            {
                Console.WriteLine($"tiene que ser mayor que 1 para calcular la serie Fibonacci");
            }

            else
            {
               int a = 0, b = 1, c;

                for (int i = 2 ; i <= n; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }

                Console.WriteLine($"\nF{n}:{b}");

            }
        }
    }
}







