using System.Collections.Generic;

namespace SOLID.OCP.Specifications
{
    public interface IFilterSpecification<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, 
            ISpecification<T> specification);
    }
}
