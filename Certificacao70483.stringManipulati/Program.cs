using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Certificacao70483.stringManipulati
{
    class Program
    {
        static void Main(string[] args)
        {
            var valor = "Varios valores aqui ...";
            var indexLetra = valor.IndexOf(' ');
            Console.WriteLine(indexLetra);

            var array = new ArrayList();
            var var1 = 23;
            array.Add(var1);

            Console.ReadLine();
        }

    }
}
