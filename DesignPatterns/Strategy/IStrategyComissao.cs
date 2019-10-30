using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    interface IStrategyComissao
    {
        decimal Aplicar(decimal value);
    }
}
