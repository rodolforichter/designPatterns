using System;
using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    public class SemaforoVeiculo : ISubject
    {
        public List<IObserver> Observers { get; private set; }

        public SemaforoVeiculo()
        {
            Observers = new List<IObserver>();
        }

        public void Notify(CoresSemaforo cor)
        {
            foreach(IObserver observer in Observers)
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
    }
}
