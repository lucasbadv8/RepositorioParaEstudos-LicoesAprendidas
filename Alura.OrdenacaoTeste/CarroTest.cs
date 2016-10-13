using System;
using System.Collections.Generic;
using System.Linq;
using Alura.Ordenacao;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alura.OrdenacaoTeste
{
    [TestClass]
    public class CarroTest
    {
        [TestMethod]
        public void Criando_carro()
        {
            var carro = new CarroBuilder()
                .ComId(10)
                .ComNome("Lamborgini")
                .ComPreco(20.00)
                .Build();

            Assert.AreEqual(10, carro.Id);
            Assert.AreEqual("Lamborgini", carro.Nome);
            Assert.AreEqual(20.00, carro.Preco);
        }

        [TestMethod]
        public void Criando_Lista_de_carros()
        {
            var carros = new List<Carro>();
            for (int i = 0; i < 100; i++)
            {
                carros.Add(new CarroBuilder()
                    .ComNome($"Carro {i}")
                    .ComId(i)
                    .ComPreco(i == 0 ? 2 : i * 2.5 * 100)
                    .Build());
            }

            Assert.AreEqual(100, carros.Count);

        }

        [TestMethod]
        public void TestandoOrdenacaoCarros()
        {
            var carros = new List<Carro>();
            for (int i = 0; i < 100; i++)
            {
                carros.Add(new CarroBuilder()
                    .ComNome($"Carro {i}")
                    .ComId(i)
                    .ComPreco(i == 0 ? 2000 : i * 2.5 * 100)
                    .Build());
            }

            var ordenar = new CarrosHelper(carros);
            Assert.AreEqual(100, carros.Count);
            Assert.AreEqual(250, ordenar.PesquisaCarroComMenorValorAlg().Preco);
            Assert.AreEqual(ordenar.PesquisarCarroMenorValor(), ordenar.PesquisaCarroComMenorValorAlg());


        }
        [TestMethod]
        public void OrdenacaoCarrosSorting()
        {
            var carros = new List<Carro>();
            for (var i = 0; i < 10000; i++)
            {
                carros.Add(new CarroBuilder()
                    .ComNome($"Carro {i}")
                    .ComId(i)
                    .ComPreco(i == 0 ? 2000 : i * 2.5 * 100)
                    .Build());
            }

            var ordenar = new CarrosHelper(carros);
            var ordenados = ordenar.OrdenarListaSorting();
            Assert.AreEqual(250, ordenados.OrderBy(x => x.Preco).FirstOrDefault().Preco);
  //        Assert.AreEqual(carros.OrderByDescending(x => x.Preco).FirstOrDefault(), ordenados.OrderByDescending(x => x.Preco).FirstOrDefault());

        }

        [TestMethod]
        public void OrdenacaoCarrosInsertSorting()
        {
            var carros = new List<Carro>();
            for (var i = 0; i < 10000; i++)
            {
                carros.Add(new CarroBuilder()
                    .ComNome($"Carro {i}")
                    .ComId(i)
                    .ComPreco(i == 0 ? 2000 : i * 2.5 * 100)
                    .Build());
            }

            var ordenar = new CarrosHelper(carros);
            var ordenados = ordenar.OrdenarListaNovoSorting();      
            Assert.AreEqual(250, ordenados.OrderBy(x => x.Preco).FirstOrDefault().Preco);
           // Assert.AreEqual(carros.OrderByDescending(x => x.Preco).FirstOrDefault(), ordenados.OrderByDescending(x => x.Preco).FirstOrDefault());

        }

    }
}
