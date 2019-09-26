using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public class SemaforoPedestre : IObserver, ISubject
    {
        public List<IObserver> Observers { get; private set; }

        public SemaforoPedestre()
        {
            Observers = new List<IObserver>();
        }

        public void Notify(CoresSemaforo cor)
        {
            foreach (IObserver observer in Observers)
            {
                observer.Update(cor);
            }
        }

        public void Subscribe(IObserver observer)
        {
            if (!Observers.Exists(o => o.Equals(observer)))
            {
                Observers.Add(observer);
            }
        }

        public void UnSubscribe(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Update(CoresSemaforo cor)
        {
            switch (cor)
            {
                case CoresSemaforo.Amarelo:
                    FicarAlerta();
                    break;
                case CoresSemaforo.Vermelho:
                    Andar();
                    break;
                case CoresSemaforo.Verde:
                    Parar();
                    break;
                default:
                    Parar();
                    break;
            }
        }

        private void Andar()
        {
            Console.WriteLine(this.GetType().Name + " :Verde");
        }

        private void Parar()
        {
            Console.WriteLine(this.GetType().Name + " :Vermelho");
        }

        private void FicarAlerta()
        {
            Console.WriteLine(this.GetType().Name + " :Amarelo");
        }
    }
}
