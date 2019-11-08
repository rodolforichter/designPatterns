using SOLID.OCP.Models;
using System.Collections.Generic;

namespace SOLID.OCP.AtendeOCP.Interfaces
{
    public interface IFilter_V1
    {
        public IList<Book> Filter(List<Book> list);
    }
}
