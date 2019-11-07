using System.Collections.Generic;

namespace SOLID.OCP.Specifications
{
    //IMG20
    public interface IFilterSpecification<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, 
            ISpecification<T> specification);
    }
}
