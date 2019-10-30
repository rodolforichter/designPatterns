namespace DesignPatterns.Strategy
{
    public abstract class ACalculoComissao
    {
        private decimal _comissaoPercentual;

        protected ACalculoComissao(decimal comissaoPercentual)
        {
            _comissaoPercentual = comissaoPercentual;
        }

        protected virtual decimal ObterValorComissao(decimal value) {
            return (value / 100) * _comissaoPercentual;
        }
    }
}
