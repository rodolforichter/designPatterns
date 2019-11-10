using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._0_SRP
{
    public class RG : Documento
    {
        public object Digital { get; internal set; }
        public string Numero { get; internal set; }       
    }
}
