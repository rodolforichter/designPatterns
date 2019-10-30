using System;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class PlenoComissao : ACalculoComissao, IStrategyComissao
    {
        private const int Percent = 20;

        public PlenoComissao() : base(Percent)
        {

        }

        public decimal Aplicar(decimal value)
        {
            return value + ObterValorComissao(value);
        }
    }
}
