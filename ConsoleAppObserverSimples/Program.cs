using DesignPatterns;
using DesignPatterns.Observer;
using DesignPatterns.ObserverSimples;
using System;

namespace ConsoleAppObserverSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Initialize();
        }

        private static void Initialize()
        {
            Semaforo semaforo = new Semaforo();

            Carro carro = new Carro();
            Carro carroFiat = new Carro();
            Moto moto = new Moto();

            semaforo.OnSemaforoColorUpdated += carro.Update;
            semaforo.OnSemaforoColorUpdated += moto.Update;
            semaforo.OnSemaforoColorUpdated += carroFiat.Update;

            semaforo.Acionar(CoresSemaforo.Verde);
            CoresSemaforo cor = CoresSemaforo.Verde;
            do
            {
                Console.WriteLine("Escolha 1 para Verde, 2 para Amarelo e 3 para Vermelho ou 0 para sair.");
                string color = Console.ReadLine();
                cor = (CoresSemaforo)int.Parse(color);
                semaforo.Acionar(cor);
            } while (cor != CoresSemaforo.Unknown);
        }
    }
}
