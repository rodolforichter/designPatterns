using System;

namespace DesignPatterns.ObserverSimples
{
    public abstract class Veiculo
    {
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
    }
}
