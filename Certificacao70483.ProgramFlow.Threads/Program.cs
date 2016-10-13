using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Certificacao70483.ProgramFlow.Threads
{
    class Program
    {
        static void Main()
        {
            var thread = new Thread(MeuMetodoThread);
            thread.Start();
            thread.IsBackground = true;
            thread.Join();
        }

        static void MeuMetodoThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread passou por aqui {0}", i);
                Thread.Sleep(0);
            }
        }
    }
}
