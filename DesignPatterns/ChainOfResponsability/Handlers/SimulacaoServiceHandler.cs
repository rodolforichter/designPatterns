using System;

namespace DesignPatterns.ChainOfResponsability.Handlers
{
    /// <summary>
    /// Classe abstrata que abstrai o Handler e será herdada pelos demais Handlers.
    /// </summary>
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

        public void Processar(Simulacao simulacao)
        {
            //Verifica se a Etapa foi recrutada para a simulação.
            if (_etapaSimulacao == (simulacao.Etapa & _etapaSimulacao))
            {
                Console.WriteLine($"{this.GetType().Name} fornecendo {this._etapaSimulacao} etapa.");

                Console.WriteLine();

                //Remove a Etapa que foi processada.
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
                //Chama o próximo Handler
                _nextHandler.Processar(simulacao);
            }
        }

        /// <summary>
        /// Define o próximo Handler que será chamado.
        /// </summary>
        /// <param name="handler"></param>
        public void SetNextServiceHandler(SimulacaoServiceHandler handler)
        {
            _nextHandler = handler;
        }

        #endregion
    }
}
