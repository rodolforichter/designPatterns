using SOLID.OCP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.Specifications
{
    public class BookCategorySpecification : ISpecification<Book>
    {
        private TypeCategory _typeCategory;

        public BookCategorySpecification(TypeCategory typeCategory)
        {
            _typeCategory = typeCategory;
        }

        public bool IsSatisfied(Book item)
        {
            return _typeCategory.Equals(item.TypeCategory);
        }
    }
}
