using SOLID.OCP.Models;
using System.Collections.Generic;

namespace SOLID.OCP.Specifications
{
    //IMG21
    public class FilterBooks : IFilterSpecification<Book>
    {
        public IEnumerable<Book> Filter(IEnumerable<Book> items, ISpecification<Book> specification)
        {
            foreach(var o in items)
            {
                if (specification.IsSatisfied(o))
                {
                    yield return o;
                }
            }
        }
    }
}
