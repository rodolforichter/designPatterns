using DesignPatterns.ChainOfResponsability;
using DesignPatterns.ChainOfResponsability.Handlers;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
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


            Console.WriteLine("**********************Simulação para o Sr José.******************************");

            Console.WriteLine();

            analistaImovel.Processar(new Simulacao { Etapa = EtapasSimulacao.AnaliseRiscoArea | EtapasSimulacao.InclusaoCoberturaRoubo | EtapasSimulacao.FinalizacaoSimulacao });

            Console.WriteLine("**********************Simulação para o Sr Mário.******************************");

            Console.WriteLine();

            analistaImovel.Processar(new Simulacao { Etapa = EtapasSimulacao.AnaliseRiscoArea | EtapasSimulacao.AnaliseRiscoHistorico | EtapasSimulacao.InclusaoCoberturaRoubo | EtapasSimulacao.InclusaoCoberturaCiclone | EtapasSimulacao.FinalizacaoSimulacao });


            Console.WriteLine("**********************Simulação para o Sra Raquel.******************************");

            Console.WriteLine();

            analistaImovel.Processar(new Simulacao { Etapa = EtapasSimulacao.AnaliseRiscoArea | EtapasSimulacao.AnaliseRiscoHistorico | EtapasSimulacao.InclusaoCoberturaRoubo 
                | EtapasSimulacao.InclusaoCoberturaCiclone | EtapasSimulacao.InclusaoCoberturaIncendio 
                | EtapasSimulacao.FinalizacaoSimulacao | EtapasSimulacao.InclusaoOpcoesPagamento  });

            Console.ReadLine();
            
        }
    }
}
