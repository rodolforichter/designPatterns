using System;

namespace DesignPatterns.ChainOfResponsability.Handlers
{
    public class AnalistaCoberturasHandler : SimulacaoServiceHandler
    {
        public AnalistaCoberturasHandler(EtapasSimulacao coberturas) : base(coberturas)
        {
            
        }
    }
}
