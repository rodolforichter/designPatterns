using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.AtendeOCP.Interfaces
{
    public interface IFilter<T>
    {
        public IEnumerable<T> Filter(IEnumerable<T> list);
    }
}
