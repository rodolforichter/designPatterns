using System;

namespace DesignPatterns.Strategy
{
    public class JuniorComissao : ACalculoComissao, IStrategyComissao
    {
        private const int Percent = 10;

        public JuniorComissao():base(Percent)
        {                
        }

        public decimal Aplicar(decimal value)
        {
            return value + ObterValorComissao(value);
        }
    }
}
