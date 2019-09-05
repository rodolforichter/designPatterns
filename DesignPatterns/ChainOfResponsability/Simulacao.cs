namespace DesignPatterns.ChainOfResponsability
{
    /// <summary>
    /// Representa a Simulação da Cotação.
    /// </summary>
    public class Simulacao 
    {
        public EtapasSimulacao Etapa { get; set; }

        public bool IsComplete
        {
            get
            {
                return Etapa.Equals(EtapasSimulacao.FinalizacaoSimulacao);
            }
        }
    }
}
