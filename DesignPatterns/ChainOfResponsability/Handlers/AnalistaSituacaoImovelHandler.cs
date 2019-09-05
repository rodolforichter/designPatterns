using System;

namespace DesignPatterns.ChainOfResponsability.Handlers
{
    public class AnalistaSituacaoImovelHandler : SimulacaoServiceHandler
    {
        public AnalistaSituacaoImovelHandler() : base(EtapasSimulacao.AnaliseSituacaoImovel)
        {

        }
    }
}
