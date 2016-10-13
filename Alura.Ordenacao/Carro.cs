using System.Runtime.InteropServices;

namespace Alura.Ordenacao
{
    public class Carro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Carro(int id, string nome,double preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }
    }
}
