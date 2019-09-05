using System;

namespace DesignPatterns.ChainOfResponsability
{
    [Flags]
    public enum EtapasSimulacao
    { 
        Unknown = 0,
        ColetaInformacoes = 2,
        AnaliseRiscoArea = 4,
        AnaliseRiscoHistorico = 8,
        InclusaoCoberturaIncendio = 16,  
        InclusaoCoberturaRoubo = 32,
        InclusaoCoberturaCiclone = 64,
        ConclusaoSimulacaoValores = 128,
        InclusaoOpcoesPagamento = 256,
        FinalizacaoSimulacao = 512
    }
}
