using System;

namespace DesignPatterns.ChainOfResponsability.Handlers
{
    public class AnalistaOpcoesPagamentoHandler : SimulacaoServiceHandler
    {
        public AnalistaOpcoesPagamentoHandler() : base(EtapasSimulacao.InclusaoOpcoesPagamento)
        {

        }
    }
}
