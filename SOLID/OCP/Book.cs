using System;

namespace SOLID.OCP
{
    /// <summary>
    /// IMG01
    /// </summary>
    public class Book : IComparable<Book>
    {
        #region Properties 

        public TypeCategory TypeCategory { get; set; }
        public TypePrint TypePrint { get; set; }
        public int Rate { get; set; }
        public TypeLanguage TypeLanguage { get; set; }

        #endregion


        #region Implementação da Interface IComparable
        /// <summary>
        /// Feita essa implementação apenas para geração 
        /// da Lista de Exemplo via Combinatorics
        /// </summary>
        /// <param name="other"></param>
        /// <returns>int</returns>
        public int CompareTo(Book other)
        {
            if (this.TypeCategory == other.TypeCategory &&
                this.TypeLanguage == other.TypeLanguage &&
                this.TypePrint == other.TypePrint &&
                this.Rate == other.Rate)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        #endregion
    }
}
