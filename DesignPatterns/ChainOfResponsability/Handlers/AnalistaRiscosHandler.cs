using System;

namespace DesignPatterns.ChainOfResponsability.Handlers
{
    public class AnalistaRiscosHandler : SimulacaoServiceHandler
    {
        public AnalistaRiscosHandler(EtapasSimulacao riscos) : base(riscos)
        {

        }
    }
}
