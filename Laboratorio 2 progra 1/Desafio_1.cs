using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingresos
{
    class Program
    {
        public static void CalcularIngresos()
        {
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese sus ingresos del primer mes: ");
            double ingreso1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese sus ingresos del segundo mes: ");
            double ingreso2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese sus ingresos del tercer mes: ");
            double ingreso3 = Convert.ToDouble(Console.ReadLine());

            double suma = ingreso1 + ingreso2 + ingreso3;
            double promedio = suma / 3;

            Console.WriteLine("Hola " + nombre + ", en total ganaste " + suma + " y promediaste " + promedio);
        }

        static void Main(string[] args)
        {
            CalcularIngresos();
        }
    }
}