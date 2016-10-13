using System;

namespace ExemploFilaPilha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando a Fila");

            Fila fila = new Fila();

            for (int i = 0; i < 50; i++)
            {
                fila.InsereFim(i);
            }
            
            Console.WriteLine(fila.Tamanho());


            Console.WriteLine("Removendo");
            for (int i = 0; i < 50; i++)
            {
                fila.RemoveFila();
                Console.WriteLine($"Removendo item {i}");
                Console.WriteLine($"Tamanho é {fila.Tamanho()}");
            }

            Pilha pilha = new Pilha();

            for (int i = 0; i < 50; i++)
            {
                pilha.InsereFim(i);
            }

            Console.WriteLine(pilha.Tamanho());

            Console.ReadLine();

            for (int i = 0; i < 50; i++)
            {
                pilha.Remover();
                Console.WriteLine($"Removendo item {i}");
                Console.WriteLine($"Tamanho é {pilha.Tamanho()}");
            }
            Console.ReadLine();
        }
    }
}
