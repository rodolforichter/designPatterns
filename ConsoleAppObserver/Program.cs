using DesignPatterns;
using DesignPatterns.Observer;
using System;

namespace ConsoleAppObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Initialize();
        }

        private static void Initialize()
        {
            SemaforoVeiculo semaforoVeiculo = new SemaforoVeiculo();
            SemaforoPedestre semaforoPedestre = new SemaforoPedestre();

            Pedestre pedestreA = new Pedestre();
            Pedestre pedestreB = new Pedestre();
            Pedestre pedestreC = new Pedestre();
            Veiculo veiculoA = new Veiculo();
            Veiculo veiculoB = new Veiculo();
            Veiculo veiculoC = new Veiculo();

            semaforoVeiculo.Subscribe(semaforoPedestre);

            semaforoVeiculo.Subscribe(veiculoA);
            semaforoVeiculo.Subscribe(veiculoB);
            semaforoVeiculo.Subscribe(veiculoC);

            semaforoPedestre.Subscribe(pedestreA);
            semaforoPedestre.Subscribe(pedestreB);
            semaforoPedestre.Subscribe(pedestreC);

            CoresSemaforo cor = CoresSemaforo.Verde;
            do
            {
                Console.WriteLine("Escolha 1 para Verde, 2 para Amarelo e 3 para Vermelho ou 0 para sair.");
                string color = Console.ReadLine();
                cor = (CoresSemaforo)int.Parse(color);
                semaforoVeiculo.Notify(cor);
                semaforoPedestre.Notify(cor);
            } while (cor != CoresSemaforo.Unknown);
        }
    }
}
