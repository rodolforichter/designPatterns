using System;

namespace DesignPatterns.ChainOfResponsability.Handlers
{
    public class AnalistaFinalizadorHandler : SimulacaoServiceHandler
    {
        public AnalistaFinalizadorHandler() : base(EtapasSimulacao.FinalizacaoSimulacao)
        {

        }
    }
}
