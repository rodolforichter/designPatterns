using SOLID.OCP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID.OCP.AtendeOCP
{
    public abstract class FilterBook_V4
    {
        protected FilterBook_V4()
        {
        }

        public virtual IEnumerable<Book> Filter(IEnumerable<Book> list)
        {
            Predicate<Book> predicate = GetPredicateFilter() ?? throw new Exception();
            return list.Where(predicate.Invoke).ToList();
        }

        protected abstract Predicate<Book> GetPredicateFilter();
    }
}
