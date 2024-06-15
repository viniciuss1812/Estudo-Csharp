using DP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Interface
{
    public class StrategyCalcularPrecoTipoB : IStrategyCalcularPreco
    {
        private readonly Produto _produto;
        public StrategyCalcularPrecoTipoB(Produto produto)
        {
            _produto = produto;
        }
        public double getPrecoFinal()
        {
            Console.WriteLine("Prço Tipo B");
            if (_produto.ValorProduto.HasValue)
            {
                return Math.Round(_produto.ValorProduto.Value * 1.20, 2);
            }
            else
            {
                return 0;
            }
        }
    }
}
