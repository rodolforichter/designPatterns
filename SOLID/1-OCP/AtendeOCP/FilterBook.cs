using Shared;
using SOLID.OCP.AtendeOCP.Interfaces;
using SOLID.OCP.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLID.OCP.AtendeOCP
{
    public abstract class FilterBook : IFilter<Book>
    {
        protected FilterBook()
        {
        }

        public virtual IEnumerable<Book> Filter(IEnumerable<Book> list)
        {
            Func<Book, bool> predicate = GetPredicateFilter();
            return list.Where(predicate).ToList();
        }

        protected abstract NonNullable<Func<Book, bool>> GetPredicateFilter();
    }
}
