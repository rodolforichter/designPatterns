using System;

namespace DesignPatterns.ChainOfResponsability.Handlers
{
    public class AnalistaSituacaoImovelHandler : SimulacaoServiceHandler
    {
        public AnalistaSituacaoImovelHandler() : base(EtapasSimulacao.ConclusaoSimulacaoValores)
        {

        }

        protected override void ProcessarEtapa()
        {
            Console.WriteLine("Conclusão Simulação de Valores.");
        }
    }
}
