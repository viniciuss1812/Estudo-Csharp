using DP.Interface;
using DP.Models;

namespace TDD
{
    public class UnitTest1
    {
        [Fact]
        public void PrecoProdutoFinalTipoAIgual110()
        {
            var produto = new Produto()
            {
                Codigo = 1,
                Nome = "Cadeira",
                Tipo = "A",
                ValorProduto = 100

            };
            double esperado = 110.00;
            StrategyContextCalcularPreco context = new StrategyContextCalcularPreco();
            context.setUpdateStrategy(new StrategyCalcularPrecoTipoA(produto));

            var resultado = context.getPrecoFinal();
            Assert.Equal(esperado, resultado);
        }
        [Fact]
        public void PrecoProdutoFinalTipoARecebeNullRetorna0()
        {
            var produto = new Produto()
            {
                Codigo = 1,
                Nome = "Cadeira",
                Tipo = "A",
                ValorProduto = null

            };
            double esperado = 0;
            StrategyContextCalcularPreco context = new StrategyContextCalcularPreco();
            context.setUpdateStrategy(new StrategyCalcularPrecoTipoA(produto));

            var resultado = context.getPrecoFinal();

            Assert.Equal(esperado, resultado);
        }
        [Fact]
        public void PrecoProdutoTipoC()
        {
            var produto = new Produto()
            {
                Codigo = 1,
                Nome = "Cadeira",
                Tipo = "A",
                ValorProduto = 130

            };
            double esperado = 143;
            StrategyContextCalcularPreco context = new StrategyContextCalcularPreco();
            context.setUpdateStrategy(new StrategyCalcularPrecoTipoA(produto));

            var resultado = context.getPrecoFinal();

            Assert.Equal(esperado, resultado);
        }
    }
}