namespace Alura.Ordenacao
{
    public class CarroBuilder
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Preco { get; private set; }

        public CarroBuilder ComId(int id)
        {
            Id = id;
            return this;
        }

        public CarroBuilder ComNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public CarroBuilder ComPreco(double preco)
        {
            Preco = preco;
            return this;
        }

        public Carro Build()
        {
            return new Carro(Id,Nome,Preco);
        }
    }
}
