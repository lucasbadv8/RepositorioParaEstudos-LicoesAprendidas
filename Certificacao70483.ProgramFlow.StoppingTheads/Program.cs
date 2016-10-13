using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Certificacao70483.ProgramFlow.StoppingTheads
{
    class Program
    {
        static void Main(string[] args)
        {
            bool parar = false;
            var t = new Thread(() =>
            {
                int i=0;
                while (!parar)
                {
                    Console.WriteLine("Aperte algum botão para parar a Thread!");
                    Console.WriteLine("{0}",i++);
                    Thread.Sleep(10);
                    Console.Clear();
                }
            });
            t.Start();
            Console.ReadKey();
            parar = true;
            t.Join();
        }
    }
}
