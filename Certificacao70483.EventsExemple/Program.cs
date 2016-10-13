using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Certificacao70483.EventsExemple
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro();
           // meuCarro.AlertaAltaVelocidade += () => Console.WriteLine("Ta Correndo pra caraleo!!");
#line 18

            meuCarro.AcessarEvento();

#line 26

            for (int i = 0; i <= 100; i++)
            {
                meuCarro.Velocidade = i;
                Thread.Sleep(500);
            }
            Console.ReadLine();
            
        }
    }
}
