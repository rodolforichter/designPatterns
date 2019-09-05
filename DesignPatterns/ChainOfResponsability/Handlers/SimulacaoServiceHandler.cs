using System;

namespace DesignPatterns.ChainOfResponsability.Handlers
{
    public abstract class SimulacaoServiceHandler
    {
        #region Attributes 

        protected SimulacaoServiceHandler _nextHandler;
        protected EtapasSimulacao _etapaSimulacao;

        #endregion

        protected SimulacaoServiceHandler(EtapasSimulacao etapaSimulacao)
        {
            _etapaSimulacao = etapaSimulacao;
        }

        #region Methods

        protected abstract void ProcessarEtapa();

        public void Processar(Simulacao simulacao)
        {
            if (_etapaSimulacao == (simulacao.Etapa & _etapaSimulacao))
            {
                Console.WriteLine($"{this.GetType().Name} providing {this._etapaSimulacao} etapas.");

                Console.WriteLine();

                simulacao.Etapa &= ~_etapaSimulacao;
            }

            if (simulacao.IsComplete || _nextHandler == null)
            {
                Console.WriteLine("Concluída a Simulação.");

                Console.WriteLine();

                return;
            }
            else
            {
                _nextHandler.Processar(simulacao);
            }
        }

        public void SetNextServiceHandler(SimulacaoServiceHandler handler)
        {
            _nextHandler = handler;
        }

        #endregion
    }
}
