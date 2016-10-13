using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Certificacao70483.ProgramFlow.ThreadResult
{
    class Program
    {
        static void Main(string[] args)
        {

            bool parar = false;
            Task<string> t = Task.Run(() =>
            {
                int i = 0;
                while (!parar)
                {
                    Console.WriteLine("Aperte algum botão para parar a Thread!");
                    Console.WriteLine("{0}", i++);
                    Thread.Sleep(10);
                    Console.Clear();
                }
                return"Thread Parou!";
            });

            Console.ReadKey();
            parar = true;
            Console.WriteLine(t.Result);
            Console.ReadKey();
        }
    }
}
