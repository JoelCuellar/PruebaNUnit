using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCalculadora
{
    public class Calculadora
    {
        static void Main(string[] args)
        {
        }

        public int Sumar(int a, int b)
        {
            return a + b; ;
        }

        public int Dividir(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("No se puede dividir entre cero.");
            return a / b;
        }
    }

   
}
