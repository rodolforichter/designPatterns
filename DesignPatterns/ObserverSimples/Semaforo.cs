using System;
using DesignPatterns.ObserverSimples;

namespace DesignPatterns.Observer
{

    public class Semaforo
    {
        #region Attributes 
        public delegate void SemaforoColorUpdated(CoresSemaforo cor);
        public event SemaforoColorUpdated OnSemaforoColorUpdated;
        #endregion

        public void Update(CoresSemaforo cor)
        {
            if(OnSemaforoColorUpdated != null)
            {
                OnSemaforoColorUpdated(cor);
            }
        }

        public void Acionar(CoresSemaforo cor)
        {
            Update(cor);
        }
    }
}
