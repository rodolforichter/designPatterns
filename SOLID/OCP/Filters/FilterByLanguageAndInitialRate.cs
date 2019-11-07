using Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.Filters
{
    /// <summary>
    /// IMG10
    /// </summary>
    public class FilterByLanguageAndInitialRate : FilterBook
    {
        private TypeLanguage TypeLanguage { get; set; }
        private int Rate { get; set; }

        public FilterByLanguageAndInitialRate(TypeLanguage typeLanguage, int rate)
        {
            TypeLanguage = typeLanguage;
            Rate = rate;
        }

        protected override NonNullable<Func<Book, bool>> GetPredicateFilter()
        {
            Func<Book, bool> pred = (Book book) => { return book.TypeLanguage.Equals(TypeLanguage) && (book.Rate > Rate); };
            return pred;
        }
    }
}
