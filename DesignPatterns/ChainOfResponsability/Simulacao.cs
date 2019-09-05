namespace DesignPatterns.ChainOfResponsability
{
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
