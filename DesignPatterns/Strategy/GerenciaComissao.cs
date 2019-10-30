using System;

namespace DesignPatterns.Strategy
{
    public class GerenciaComissao
    {
        public decimal ApplyCommisssion(Vendedor vendedor, decimal totalVenda)
        {
            IStrategyComissao strategyCommission = null;

            if (vendedor.TipoVendedor.Equals(TipoVendedor.Junior))
            {
                strategyCommission = new JuniorComissao();
            }
            else if (vendedor.TipoVendedor.Equals(TipoVendedor.Pleno))
            {
                strategyCommission = new PlenoComissao();
            }
            else
            {
                throw new ArgumentException("Tipo de vendedor deve ser especificado.");
            }

            return strategyCommission.Aplicar(totalVenda);
        }
    }
}
