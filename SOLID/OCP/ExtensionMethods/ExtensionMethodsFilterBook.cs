using SOLID.OCP.Models;
using System.Collections.Generic;
using System.Linq;

namespace SOLID.OCP.ExtensionMethods
{
    public static class ExtensionMethodsFilterBook
    {
        public static IEnumerable<Book> FilterByLanguage(this FilterBookWithoutOCP_V1 filter,
            IList<Book> list, TypeLanguage language)
        {
            return list.Where(x => x.TypeLanguage.Equals(language)).ToList();
        }

        public static IEnumerable<Book> FilterByCategory(this FilterBookWithoutOCP_V1 filer,
            IList<Book> list, TypeCategory category)
        {
            return list.Where(x => x.TypeCategory.Equals(category)).ToList();
        }
    }
}
