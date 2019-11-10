using SOLID.OCP.Models;

namespace SOLID.OCP.Specifications
{
    public class BookLanguageSpecification : ISpecification<Book>
    {
        private TypeLanguage _typeLanguage;

        public BookLanguageSpecification(TypeLanguage typeLanguage)
        {
            _typeLanguage = typeLanguage;
        }

        public bool IsSatisfied(Book item)
        {
            return _typeLanguage.Equals(item.TypeLanguage);
        }
    }
}
