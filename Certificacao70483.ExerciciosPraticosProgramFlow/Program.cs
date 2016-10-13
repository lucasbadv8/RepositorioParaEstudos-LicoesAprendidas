using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Certificacao70483.ExerciciosPraticosProgramFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread = new Thread(new ThreadStart(MeuMetodoThread));
            thread.Start();

            for (int i=0; i < 4; i++)
            {
                Console.WriteLine("Inicio do processamento");
                Thread.Sleep(1);
            }
            thread.Join();
        }

        static void MeuMetodoThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread passou por aqui {0}",i);
                Thread.Sleep(0);
            }
        }

    }
}
