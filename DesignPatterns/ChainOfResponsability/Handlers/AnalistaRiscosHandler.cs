using System;

namespace DesignPatterns.ChainOfResponsability.Handlers
{
    public class AnalistaRiscosHandler : SimulacaoServiceHandler
    {
        public AnalistaRiscosHandler(EtapasSimulacao riscos) : base(riscos)
        {

        }

        protected override void ProcessarEtapa()
        {
            Console.WriteLine("Realizada Análise de Histórico");
        }
    }
}
