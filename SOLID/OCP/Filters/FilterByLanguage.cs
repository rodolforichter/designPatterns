using Shared;
using System;

namespace SOLID.OCP.Filters
{
    /// <summary>
    /// IMG09
    /// </summary>
    public class FilterByLanguage : FilterBook
    {
        private TypeLanguage TypeLanguage { get; set; }

        public FilterByLanguage(TypeLanguage typeLanguage)
        {
            TypeLanguage = typeLanguage;
        }

        protected override NonNullable<Func<Book,bool>> GetPredicateFilter()
        {
            Func<Book, bool> pred = (Book book) => { return book.TypeLanguage.Equals(TypeLanguage); };
            return pred;
        }
    }
}
