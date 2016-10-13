using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ProtocolosParalel
{
    class Program
    {
        internal class Protocolo
        {
            public Protocolo(List<Guia> guias)
            {
                Guias = new List<Guia>();
                Guias = guias;
            }

            public int IdProtocolo { get; set; }
            public List<Guia> Guias { get; set; }
        }

        internal class Guia
        {
            public Guia(List<int> eventos)
            {
                Eventos = new List<int>();
                Eventos = eventos;
            }

            public int IdGuia { get; set; }
            public List<int> Eventos { get; set; }
        }

        private static List<Protocolo> Protocolos = new List<Protocolo>();

        static void Main(string[] args)
        {
            CriarCasos(Convert.ToInt32(Console.ReadLine()));
            //var protocolosPrestador = Enumerable.Range(0, 10);
            //var listaDeObjetosProcessados = new List<int>();
            Console.WriteLine("***************************************");
            Console.WriteLine("******* Processando Protocolos ********");
            Console.WriteLine("***************************************");
            Stopwatch watch = Stopwatch.StartNew();
            // PROTOCOLOS PRESTADOR
            Parallel.ForEach(Protocolos, i =>
            {
                Stopwatch watchp = Stopwatch.StartNew();
                var valor = Protocolos.Where(x => x.IdProtocolo == i.IdProtocolo).Select(x => x.IdProtocolo).First();
                Console.WriteLine("Protocolo  {0}", valor);

                // IR A NIVEL DE GUIA
                var guias = Protocolos.SelectMany(x => x.Guias).ToList();
                ProcessarGuia(guias);

                Console.WriteLine("GC");
                GC.Collect();

                Console.WriteLine("Protocolo {0} finalizado com: {1}ms", valor, watchp.ElapsedMilliseconds);

            });
            watch.Stop();
            Console.WriteLine("Finalizado com: {0}ms", watch.ElapsedMilliseconds);
            Console.ReadLine();
        }

        private static void CriarCasos(int quantidade)
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("*********   Criando Casos  ************");
            Console.WriteLine("***************************************");
            Stopwatch watch = Stopwatch.StartNew();
            Parallel.For(0, quantidade, i =>
            {
                Protocolos.Add(new Protocolo(MontarGuias())
                {
                    IdProtocolo = i
                });
            });
            watch.Stop();
            Console.WriteLine(" foram criados {1} protocolos em: {0}ms", watch.ElapsedMilliseconds, quantidade);
        }

        public static List<Guia> MontarGuias()
        {
            var guias = new List<Guia>();
            Parallel.For(0, 10, j =>
            {
                guias.Add(new Guia(Enumerable.Range(1, 10).ToList())
                {
                    IdGuia = j
                });
            });
            return guias;
        }

        private static void ProcessarGuia(List<Guia> pguias)
        {
            var guias = new HashSet<Guia>(pguias);
            Parallel.ForEach(guias, i =>
            {
                // IR A NIVEL DE evento
                var eventos = guias.SelectMany(x => x.Eventos);
                ProcessarEventos(eventos);

            });
        }

        private static void ProcessarEventos(IEnumerable<int> eventos)
        {
            HashSet<int> ev = new HashSet<int>(eventos);
            Parallel.ForEach(ev, i =>
            {
                Thread.Sleep(3);
            });
        }
    }
}