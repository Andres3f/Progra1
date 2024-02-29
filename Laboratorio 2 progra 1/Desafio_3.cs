using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    class Program
    {
        public static void Sumar()
        {
            int a, b;

            Console.WriteLine("Ingrese dos números enteros para sumarlos: ");

            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("La suma de {0} y {1} es {2}", a, b, a + b);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: El valor introducido no es un número válido");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Fin del programa");
            }
        }

        static void Main(string[] args) => Sumar();
    }
}