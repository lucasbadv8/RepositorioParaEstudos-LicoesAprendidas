using System;
using System.Threading;
using System.Threading.Tasks;

namespace Certificacao70483.CancellationToken
{
    class Program
    {
        static void Main(string[] args)
        {

            CancellationTokenSource cancellationTokenSource = new System.Threading.CancellationTokenSource();
            System.Threading.CancellationToken token = cancellationTokenSource.Token;

            Task minhaTask = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.Write("*");
                    Thread.Sleep(1000);
                }
                token.ThrowIfCancellationRequested();
            },token);
            try
            {
                Console.WriteLine("Pressione enter para parar a tarefa");
                while (!token.IsCancellationRequested)
                {
                    if (Console.ReadKey().Key.Equals(ConsoleKey.Enter))
                    {
                        cancellationTokenSource.Cancel();
                        Console.WriteLine("tarefa parada");
                        Console.ReadLine();
                    }

                    
                }
                
            }
            catch (AggregateException e)
            {
                
                Console.WriteLine(e.InnerExceptions[0].Message);
                Console.ReadLine();
            }
            

        }
    }
}
