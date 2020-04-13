using System;

namespace Calculadora
{
    class Program
    {
        private static Aritmetica _aritmetica = new Aritmetica();

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la Calculadora:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("0. Salir");
            string input = Console.ReadLine().ToLower().Trim();
            try
            {
                int intInput = int.Parse(input);
                int a = 0, b = 0;
                switch (intInput)
                {
                    case 1:
                        Console.WriteLine("Ingrese el primer factor:");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo factor:");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado es: "+_aritmetica.Suma(a, b));
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puede leer el input porque no es un numero:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
