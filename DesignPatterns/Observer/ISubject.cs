using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    public interface ISubject
    {
        List<IObserver> Observers { get;  }
        void Subscribe(IObserver observer);
        void UnSubscribe(IObserver observer);
        void Notify(CoresSemaforo cor);
    }
}
