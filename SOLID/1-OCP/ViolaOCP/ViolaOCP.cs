using SOLID.OCP.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLID.OCP
{
    public class FilterBookWithoutOCP_V1
    {
        public List<Book> Filter(List<Book> books)
        {
            return books.Where(b => b.TypeCategory.Equals(TypeCategory.Philosophy)).ToList();
        }
    }

    public class FilterBookWithoutOCP_V2
    {
        public List<Book> FilterByCategory(List<Book> books, TypeCategory category)
        {
            return books.Where(b => b.TypeCategory.Equals(category)).ToList();
        }
    }

    public class FilterBookWithoutOCP_V3
    {
        public IList<Book> FilterByCategory(IList<Book> books, TypeCategory category)
        {
            return books.Where(b => b.TypeCategory.Equals(category)).ToList();
        }

        public IList<Book> FilterByLanguage(IList<Book> books, TypeLanguage language)
        {
            return books.Where(b => b.TypeLanguage.Equals(language)).ToList();
        }
    }

    public class FilterBookWithoutOCP_V4
    {
        public IList<Book> Filter(IList<Book> books, TypeCategory? category, TypeLanguage? language)
        {
            if (category.HasValue && language.HasValue)
            {
                return books.Where(b => b.TypeCategory.Equals(category) && b.TypeLanguage.Equals(language)).ToList();
            }
            else if (category.HasValue)
            {
                return books.Where(b => b.TypeCategory.Equals(category)).ToList();
            }
            else
            {
                return books.Where(b => b.TypeLanguage.Equals(language)).ToList();
            }
        }
    }

    public class FilterBookWithoutOCP_V5
    {
        public IList<Book> Filter(List<Book> books, Predicate<Book> predicate)
        {
            return books.Where(predicate.Invoke).ToList();
        }
    }
}
