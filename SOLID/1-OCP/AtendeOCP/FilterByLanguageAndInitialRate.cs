using Shared;
using SOLID.OCP.AtendeOCP;
using SOLID.OCP.Models;
using System;

namespace SOLID.OCP.AtendeOCP
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
