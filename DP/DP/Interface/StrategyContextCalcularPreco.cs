using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Interface
{
    public class StrategyContextCalcularPreco
    {
        private IStrategyCalcularPreco _strategy;
        public void setUpdateStrategy(IStrategyCalcularPreco strategy)
        {
            _strategy = strategy;
        }
        public double getPrecoFinal()
        {
            return _strategy.getPrecoFinal();
        }
    }
}
