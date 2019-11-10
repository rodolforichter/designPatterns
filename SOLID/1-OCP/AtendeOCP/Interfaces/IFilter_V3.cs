using System;
using System.Collections.Generic;

namespace SOLID.OCP.AtendeOCP.Interfaces
{
    public interface IFilter_V3<T>
    {
        public IEnumerable<T> Filter(IEnumerable<T> list, Predicate<T> predicate);
    }
}
