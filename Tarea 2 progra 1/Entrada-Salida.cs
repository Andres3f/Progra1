using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada_Salida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.Write("escribe tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("¿Que tal? " + nombre);
            Console.Read();
        }
    }
}
