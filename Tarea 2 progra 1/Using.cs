using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto1;
            using (TextWriter w = File.CreateText("log.txt"))
            {
                w.WriteLine("linea 1");
                w.WriteLine("linea 2");

            }
            using (TextReader r = File.OpenText("log.txt"))
            {
                while ((texto1 = r.ReadLine()) != null)
                {
                    Console.WriteLine(texto1);
                }
            }
            Console.ReadLine();
        }
    }
}
