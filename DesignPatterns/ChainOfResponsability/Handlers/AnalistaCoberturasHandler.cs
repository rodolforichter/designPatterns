using System;

namespace DesignPatterns.ChainOfResponsability.Handlers
{
    public class AnalistaCoberturasHandler : SimulacaoServiceHandler
    {
        public AnalistaCoberturasHandler(EtapasSimulacao coberturas) : base(coberturas)
        {

        }

        protected override void ProcessarEtapa()
        {
            Console.WriteLine("Análise do especialista de cobertura");
        }
    }
}
