using System;

namespace DesignPatterns.Observer
{
    public class Veiculo : IObserver
    {
        public void Update(CoresSemaforo cor)
        {
            switch (cor)
            {
                case CoresSemaforo.Amarelo:
                    FicarAlerta();
                    break;
                case CoresSemaforo.Verde:
                    Andar();
                    break;
                case CoresSemaforo.Vermelho:
                    Parar();
                    break;
                default:
                    Parar();
                    break;
            }
        }

        private void Andar()
        {
            Console.WriteLine(this.GetType().Name + " :Andar");
        }

        private void Parar()
        {
            Console.WriteLine(this.GetType().Name + " :Parar");
        }

        private void FicarAlerta()
        {
            Console.WriteLine(this.GetType().Name + " :Ficar Alerta");
        }
    }
}
