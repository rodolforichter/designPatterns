using System;

namespace DesignPatterns.ChainOfResponsability
{
    /// <summary>
    /// possíveis etapas da Simulação de uma cotação.
    /// </summary>
    [Flags]
    public enum EtapasSimulacao
    { 
        Unknown = 0,
        ColetaInformacoes = 2,
        AnaliseRiscoArea = 4,
        AnaliseRiscoHistorico = 8,
        AnaliseSituacaoImovel = 16,
        InclusaoCoberturaIncendio = 32,  
        InclusaoCoberturaRoubo = 64,
        InclusaoCoberturaCiclone = 128,
        InclusaoOpcoesPagamento = 256,
        FinalizacaoSimulacao = 512
    }
}
