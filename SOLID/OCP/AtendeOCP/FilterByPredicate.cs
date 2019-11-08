using Shared;
using SOLID.OCP.AtendeOCP;
using SOLID.OCP.Models;
using System;
using System.Collections.Generic;

namespace SOLID.OCP.AtendeOCP
{
    public class FilterByPredicate : FilterBook
    {
        private Func<Book, bool> Predicate { get; set; }

        public FilterByPredicate(Func<Book, bool> predicate)
        {
            Predicate = predicate;
        }
        public IEnumerable<Book> FilterBy(IEnumerable<Book> list)
        {
            return Filter(list);
        }
        protected override NonNullable<Func<Book, bool>> GetPredicateFilter()
        {
            return Predicate;
        }
    }

   
}
