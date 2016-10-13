using System.Collections.Generic;
using System.Linq;

namespace Alura.Ordenacao
{
    public class CarrosHelper
    {
        public List<Carro> Carros { get; }

        public CarrosHelper(List<Carro> listaCarros)
        {
            Carros = listaCarros;
        }

        public Carro PesquisarCarroMenorValor()
        {
            return Carros.OrderBy(x => x.Preco).FirstOrDefault();
        }

        public Carro PesquisaCarroComMenorValorAlg()
        {
            var carroMaisBarato = 0;
            for (var i = 0; i < Carros.Count; i++)
            {
                if (Carros[i].Preco < Carros[carroMaisBarato].Preco)
                    carroMaisBarato = i;
            }
            return Carros[carroMaisBarato];
        }

        public int PesquisarCarroMenorValor(List<Carro> carros, int inicio,int termino)
        {
            var carroMaisBarato = 0;
            for (var i = 0; i < Carros.Count; i++)
            {
                if (Carros[i].Preco < Carros[carroMaisBarato].Preco)
                    carroMaisBarato = i;
            }
            return carroMaisBarato;
        }

        public List<Carro> OrdenarListaSorting()
        {
            for (var atual = 0; atual < Carros.Count - 1; atual++)
            {
                var menor = PesquisarCarroMenorValor(Carros, atual, Carros.Count);
                var carroAtual = Carros[atual];
                var carroMaisBarato = Carros[menor];
                Carros[atual] = carroMaisBarato;
                Carros[menor] = carroAtual;
            }
            return Carros;
        }

        public List<Carro> OrdenarListaNovoSorting()
        {
            for (var atual = 0; atual < Carros.Count - 1; atual++)
            {
                var analise = atual;
                while (analise > 0 && Carros[analise].Preco < Carros[analise - 1].Preco)
                {
                    var carroAnalise = Carros[analise];
                    var carroAnaliseAnterior = Carros[analise - 1];
                    Carros[analise] = carroAnaliseAnterior;
                    Carros[analise - 1] = carroAnalise;
                    analise--;
                }      
            }
            return Carros;
        }
    }
}
