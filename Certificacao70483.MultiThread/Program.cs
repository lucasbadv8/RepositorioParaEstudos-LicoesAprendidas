using System;
using System.Threading;
using System.Threading.Tasks;

namespace Certificacao70483.MultiThread
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Task minhaTask = Task.Run(() =>
            {
                for (int i =0;i<1000000;i++)
                {
                    Interlocked.Increment(ref numero);
                }
            });
            for (int i = 0; i < 1000000; i++)
            {
                Interlocked.Decrement(ref numero);
            }
            minhaTask.Wait();
            Console.WriteLine(numero);
        }
    }
}
