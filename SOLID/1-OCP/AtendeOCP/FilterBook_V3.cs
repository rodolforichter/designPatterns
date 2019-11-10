using SOLID.OCP.AtendeOCP.Interfaces;
using SOLID.OCP.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLID.OCP.AtendeOCP
{
    public class FilterBook_V3 : IFilter_V3<Book>
    {
        public virtual IEnumerable<Book> Filter(IEnumerable<Book> list, Predicate<Book> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException();
            }
            return list.Where(predicate.Invoke).ToList();
        }
    }
}
