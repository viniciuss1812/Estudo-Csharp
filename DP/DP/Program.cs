// See https://aka.ms/new-console-template for more information
using DP.Interface;
using DP.Models;

var produto = new Produto()
{
    Codigo = 1,
    Nome = "Cadeira",
    Tipo = "A",
    ValorProduto = 100
};
StrategyContextCalcularPreco contextpreco = new StrategyContextCalcularPreco();
contextpreco.setUpdateStrategy(new StrategyCalcularPrecoTipoA(produto));
Console.WriteLine(contextpreco.getPrecoFinal());

contextpreco.setUpdateStrategy(new StrategyCalcularPrecoTipoB(produto));
Console.WriteLine(contextpreco.getPrecoFinal());

