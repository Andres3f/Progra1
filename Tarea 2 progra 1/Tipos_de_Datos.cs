using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_de_Datos
{
    internal class tiposDeDatos
    {
        static void Main(string[] args)
        {
            sbyte byteConSigno = sbyte.MaxValue;
            byte primerByte = byte.MaxValue;
            short miPrimerShort = short.MaxValue;
            ushort miPrimerUshort = ushort.MaxValue;
            int primerInteger = int.MaxValue;
            uint PrimerUint = uint.MaxValue;
            long primerLong = long.MaxValue;
            ulong primerUlong = ulong.MaxValue;
            float primerFloat = float.MaxValue;
            double primerDouble = double.MaxValue;
            decimal primerDecimal = decimal.MaxValue;

            Console.WriteLine("Estos son los resultados de los tipos de datos: ");
            Console.WriteLine("Max[sbyte]: {0} ", byteConSigno);
            Console.WriteLine("Max[byte]: {0} ", primerByte);
            Console.WriteLine("Max[short]: {0} ", miPrimerShort);
            Console.WriteLine("Max[ushort]: {0} ", miPrimerUshort);
            Console.WriteLine("Max[int]: {0} ", primerInteger);
            Console.WriteLine("Max[uint]: {0} ", PrimerUint);
            Console.WriteLine("Max[long]: {0} ", primerLong);
            Console.WriteLine("Max[ulong]: {0} ", primerUlong);
            Console.WriteLine("Max[float]: {0} ", primerFloat);
            Console.WriteLine("Max[double]: {0} ", primerDouble);
            Console.WriteLine("Max[decimal]: {0} ", primerDecimal);
            Console.ReadLine();
        }
    }
}
