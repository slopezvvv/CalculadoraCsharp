using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Aritmetica
    {
        public int Suma(int a, int b)
        {
            return a+b;
        }
        public int Resta(int a, int b)
        {
            return a-b;
        }
        public int Multi(int a, int b)
        {
            return a*b;
        }

        public int Divi(double tmpDividendo, double tmpDivisor)
        {
            int divisor = int.Parse(Math.Round(tmpDivisor).ToString());
            int dividendo = int.Parse(Math.Round(tmpDividendo).ToString());
            if (divisor == 0) {
                Console.WriteLine("La division por cero no es valida.");
                return 0;
            }

            if (dividendo == 0)
                return 0;

            return dividendo/divisor;
        }
    }
}
