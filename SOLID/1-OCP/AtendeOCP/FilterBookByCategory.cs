using SOLID.OCP.AtendeOCP.Interfaces;
using SOLID.OCP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID.OCP.AtendeOCP
{
    public class FilterBookByCategory : IFilter_V1
    {
        private TypeCategory _typeCategory;

        public FilterBookByCategory(TypeCategory typeCategory)
        {
            _typeCategory = typeCategory;
        }
        public IList<Book> Filter(List<Book> list)
        {
            return list.Where(x => x.TypeCategory == _typeCategory).ToList();
        }
    }
}
