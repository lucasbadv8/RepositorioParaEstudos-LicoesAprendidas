using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
using static System.Threading.Thread;

namespace Certificacao70483.ProgramFlow.Async
{
    class Program
    {
        static void Main()
        {
            Task.Run(() =>
            {
                var t1 = new Thread(() =>
                {
                    var result = DownloadTeste().Result;
                    WriteLine("Download Iniciado");
                    for (var i = 0; i <= 100; i++)
                    {
                        WriteLine("Download {0}%",i);
                        Sleep(100);
                    }
                    Write(result);
                });
                t1.Start();

            });
            WriteLine("Cliquei em download!");
            Sleep(1000);
            var t2 = new Thread((() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    WriteLine("Mexendo em outros paranaues");
                    Sleep(1000);
                }
               
            }));

            t2.Start();

            t2.Join();

        }

        public static async Task<string> DownloadTeste()
        {
            using (HttpClient client = new HttpClient())
            {
                string resultado = await client.GetStringAsync("https://www.google.com");
                return resultado;
            }
        }
    }
}
