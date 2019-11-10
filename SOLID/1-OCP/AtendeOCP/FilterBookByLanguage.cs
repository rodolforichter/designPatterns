using SOLID.OCP.AtendeOCP.Interfaces;
using SOLID.OCP.Models;
using System.Collections.Generic;
using System.Linq;

namespace SOLID.OCP.AtendeOCP
{
    public class FilterBookByLanguage : IFilter_V1
    {
        private TypeLanguage _typeLanguage;

        public FilterBookByLanguage(TypeLanguage typeLanguage)
        {
            _typeLanguage = typeLanguage;
        }
        public IList<Book> Filter(List<Book> list)
        {
            return list.Where(x => x.TypeLanguage == _typeLanguage).ToList();
        }
    }
}
