using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.AtendeOCP.Interfaces
{
    public interface IFilter_V2<T>
    {
        public IList<T> Filter(List<T> list, Predicate<T> predicate);
    }
}
