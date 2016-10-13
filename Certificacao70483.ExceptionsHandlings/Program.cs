using System;
using Certificacao70483.ExceptionsHandlings.TEste;

namespace Certificacao70483.ExceptionsHandlings
{
    class Program
    {
        static void Main()
        {
            using (var c = new ConcatenaNome())
            {
                try
                {
                    var nome = "Lucas";
                    var sobrenome = "Lopes";

                    var nomeCompleto = c.ConcatenarNomes(nome, sobrenome);
                    Console.WriteLine(nomeCompleto);

                    nomeCompleto = c.ConcatenarNomes(null, sobrenome);
                    Console.WriteLine(nomeCompleto);
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            dynamic a = "asas";
            a = 5;
            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}
