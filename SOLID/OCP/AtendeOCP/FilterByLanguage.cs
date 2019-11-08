using Shared;
using SOLID.OCP.AtendeOCP;
using SOLID.OCP.Models;
using System;

namespace SOLID.OCP.AtendeOCP
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
