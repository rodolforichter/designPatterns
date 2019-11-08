using SOLID.OCP.AtendeOCP.Interfaces;
using SOLID.OCP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID.OCP.AtendeOCP
{
    public abstract class FilterBook_V2 : IFilter_V2<Book>
    {
        public IList<Book> Filter(List<Book> list, Predicate<Book> predicate)
        {
            return list.Where(predicate.Invoke).ToList();
        }
    }
}
