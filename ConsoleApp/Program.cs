using DesignPatterns.ChainOfResponsability;
using DesignPatterns.ChainOfResponsability.Handlers;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SimularCotacao();
        }

        #region Methods 

        private static void SimularCotacao()
        {
            AnalistaCoberturasHandler analistaCoberturasRoubo = new AnalistaCoberturasHandler(EtapasSimulacao.InclusaoCoberturaRoubo);
            AnalistaCoberturasHandler analistaCoberturasCiclone = new AnalistaCoberturasHandler(EtapasSimulacao.InclusaoCoberturaCiclone);
            AnalistaCoberturasHandler analistaCoberturasIncendio = new AnalistaCoberturasHandler(EtapasSimulacao.InclusaoCoberturaIncendio);
            AnalistaRiscosHandler analistaRiscos = new AnalistaRiscosHandler(EtapasSimulacao.AnaliseRiscoArea);
            AnalistaRiscosHandler analistaHistorico = new AnalistaRiscosHandler(EtapasSimulacao.AnaliseRiscoHistorico);
            AnalistaSituacaoImovelHandler analistaImovel = new AnalistaSituacaoImovelHandler();
            AnalistaOpcoesPagamentoHandler analistaOpcoesPagto = new AnalistaOpcoesPagamentoHandler();
            AnalistaFinalizadorHandler analistaFinalizacao = new AnalistaFinalizadorHandler();


            analistaImovel.SetNextServiceHandler(analistaCoberturasRoubo);
            analistaCoberturasRoubo.SetNextServiceHandler(analistaCoberturasCiclone);
            analistaCoberturasCiclone.SetNextServiceHandler(analistaCoberturasIncendio);
            analistaCoberturasIncendio.SetNextServiceHandler(analistaRiscos);
            analistaRiscos.SetNextServiceHandler(analistaHistorico);
            analistaHistorico.SetNextServiceHandler(analistaOpcoesPagto);
            analistaOpcoesPagto.SetNextServiceHandler(analistaFinalizacao);

            SimulacaoClienteJose(analistaImovel);
            SimulacaoClienteMario(analistaImovel);
            SimulacaoClienteRaquel(analistaImovel);

            Console.ReadLine();
        }

        private static void SimulacaoClienteRaquel(AnalistaSituacaoImovelHandler analistaImovel)
        {
            Console.WriteLine("**********************Simulação para a Sra Raquel.******************************");

            Console.WriteLine();

            analistaImovel.Processar(new Simulacao
            {
                Etapa = EtapasSimulacao.AnaliseRiscoArea | EtapasSimulacao.AnaliseRiscoHistorico | EtapasSimulacao.InclusaoCoberturaRoubo
                | EtapasSimulacao.InclusaoCoberturaCiclone | EtapasSimulacao.InclusaoCoberturaIncendio | EtapasSimulacao.AnaliseSituacaoImovel
                | EtapasSimulacao.FinalizacaoSimulacao | EtapasSimulacao.InclusaoOpcoesPagamento
            });
        }

        private static void SimulacaoClienteMario(AnalistaSituacaoImovelHandler analistaImovel)
        {
            Console.WriteLine("**********************Simulação para o Sr Mário.******************************");

            Console.WriteLine();

            analistaImovel.Processar(new Simulacao { Etapa = EtapasSimulacao.AnaliseRiscoArea | EtapasSimulacao.AnaliseRiscoHistorico | EtapasSimulacao.InclusaoCoberturaRoubo | EtapasSimulacao.InclusaoCoberturaCiclone | EtapasSimulacao.FinalizacaoSimulacao });
        }

        private static void SimulacaoClienteJose(AnalistaSituacaoImovelHandler analistaImovel)
        {
            Console.WriteLine("**********************Simulação para o Sr José.******************************");

            Console.WriteLine();

            analistaImovel.Processar(new Simulacao { Etapa = EtapasSimulacao.AnaliseRiscoArea | EtapasSimulacao.InclusaoCoberturaRoubo | EtapasSimulacao.FinalizacaoSimulacao });
        }

        #endregion
    }
}
