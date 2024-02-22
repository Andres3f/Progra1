using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condiciones
{
    internal class Program
    {


        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero:");
            try
            {
                int numeroEntero = int.Parse(Console.ReadLine());

                if (numeroEntero == 7)
                    Console.WriteLine("Numero Entero es 7.");
                else if (numeroEntero < 0)
                    Console.WriteLine("Numero Entero es incorrecto");
                else
                {
                    Console.WriteLine("NumerEntero no es ninguno de los casos programados");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: No ha ingresado un número entero válido.");
            }

            Console.ReadLine();
        }
    }
}