using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.Specifications
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }
}
