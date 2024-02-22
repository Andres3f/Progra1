using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leer_Teclado
{
    internal class LeerTeclado
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero de la suma: ");
            string numeroIngresado = Console.ReadLine();
            int num1 = int.Parse(numeroIngresado);
            Console.WriteLine("Ingrese el segundo numero de la suma: ");
            string segundoNumeroIngresado = Console.ReadLine();
            int num2 = int.Parse(segundoNumeroIngresado);
            int resultado = num1 + num2;
            Console.WriteLine("El resultados de la suma de {0} + {1} es de: {2}", num1, num2, resultado);
            Console.ReadLine();

        }
    }
}