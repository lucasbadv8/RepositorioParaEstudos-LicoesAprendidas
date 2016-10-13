using System;
using System.Threading;

namespace Certificacao70483.ProgramFlow.ThreadParameters
{
    class Program
    {
        static void Main()
        {
            var thread = new Thread(MeuMetodoThread);
            thread.Start(10);
            var thread2 = new Thread(() =>
            {
                for (var i = 0; i <= 1500; i++)
                {
                    if (i % 2 == 0) continue;

                    Console.WriteLine("Thread2 impar {0}", i);
                    Thread.Sleep(10);
                }
                Console.WriteLine("Fim!!!!!!!!");
            }); 
            thread2.Start();
            thread.IsBackground = true;
            thread.Join();
            thread2.Join();
        }

        static void MeuMetodoThread(object obj)
        {
            for (var i = 0; i < (int)obj; i++)
            {
                if (i%2 != 0) continue;

                Console.WriteLine("Thread1 Par {0}", i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Fim!!!!!!!!");
        }

    }
}
