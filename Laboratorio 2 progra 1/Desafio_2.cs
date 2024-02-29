using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class Calculadora
    {
        public static int Sumar(int a, int b)
        {
            return a + b;
        }

        public static int Restar(int a, int b)
        {
            return a - b;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public static int Dividir(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("No se puede dividir por cero");
            }
            else
            {
                return a / b;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;

            Console.WriteLine("La suma de {0} y {1} es {2}", x, y, Calculadora.Sumar(x, y));
            Console.WriteLine("La resta de {0} y {1} es {2}", x, y, Calculadora.Restar(x, y));
            Console.WriteLine("La multiplicación de {0} y {1} es {2}", x, y, Calculadora.Multiplicar(x, y));
            Console.WriteLine("La división de {0} y {1} es {2}", x, y, Calculadora.Dividir(x, y));
        }
    }
}