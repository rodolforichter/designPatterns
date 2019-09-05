using System;

namespace DesignPatterns.ChainOfResponsability.Handlers
{
    public class AnalistaOpcoesPagamentoHandler : SimulacaoServiceHandler
    {
        public AnalistaOpcoesPagamentoHandler() : base(EtapasSimulacao.InclusaoOpcoesPagamento)
        {

        }

        protected override void ProcessarEtapa()
        {
            Console.WriteLine("Incluídas as opções de pagamento.");
        }
    }
}
