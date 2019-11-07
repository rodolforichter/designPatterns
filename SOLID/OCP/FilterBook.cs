using Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLID.OCP
{
    /// <summary>
    /// IMG02 -> Primeira versão da classe sem OCP.
    /// </summary>
    public class FilterBookWithoutOCP
    {
        public List<Book> Filter(List<Book> books)
        {
            return books.Where(b => b.TypeCategory.Equals(TypeCategory.Philosophy)).ToList();
        }
    }

    /// <summary>
    /// IMG03 -> Segunda versão da classe sem OCP.
    /// </summary>
    //public class FilterBook
    //{
    //    public List<Book> FilterByCategory(List<Book> books, TypeCategory category)
    //    {
    //        return books.Where(b => b.TypeCategory.Equals(category)).ToList();
    //    }
    //}

    /// <summary>
    /// IMG04 -> Terceira versão da classe sem OCP.
    /// </summary>
    //public class FilterBook
    //{
    //    public IList<Book> FilterByCategory(IList<Book> books, TypeCategory category)
    //    {
    //        return books.Where(b => b.TypeCategory.Equals(category)).ToList();
    //    }

    //    public IList<Book> FilterByLanguage(IList<Book> books, TypeLanguage language)
    //    {
    //        return books.Where(b => b.TypeCategory.Equals(language)).ToList();
    //    }
    //}

    /// <summary>
    /// IMG05 -> Quarta versão da classe sem OCP.
    /// </summary>
    //public class FilterBook
    //{
    //    public IList<Book> Filter(IList<Book> books, TypeCategory? category, TypeLanguage? language)
    //    {
    //        if (category.HasValue && language.HasValue)
    //        {
    //            return books.Where(b => b.TypeCategory.Equals(category) && b.TypeLanguage.Equals(language)).ToList();
    //        }
    //        else if (category.HasValue)
    //        {
    //            return books.Where(b => b.TypeCategory.Equals(category)).ToList();
    //        }
    //        else
    //        {
    //            return books.Where(b => b.TypeLanguage.Equals(language)).ToList();
    //        }
    //    }
    //}


    /// <summary>
    /// IMG06 -> Quinta versão da classe sem OCP.
    /// </summary>
    //public class FilterBook
    //{
    //    public IList<Book> Filter(List<Book> books, Predicate<Book> predicate)
    //    {
    //        return books.Where(predicate.Invoke).ToList();
    //    }
    //}

    /// <summary>
    /// IMG07 - Primeira implementação com OCP
    /// </summary>
    //public class FilterBook
    //{
    //    public virtual IEnumerable<Book> Filter(IEnumerable<Book> list, Predicate<Book> predicate)
    //    {
    //        if (predicate == null)
    //        {
    //            throw new ArgumentNullException();
    //        }
    //        return list.Where(predicate.Invoke).ToList();
    //    }
    //}


    /// <summary>
    /// IMG08 - Primeira Versão da Interface
    /// </summary>
    public interface IFilter
    {
        public IList<Book> Filter(List<Book> list);
    }

    /// <summary>
    /// IMG09 Implementação por interface
    /// </summary>
    public class FilterBookByLanguage : IFilter
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

    /// <summary>
    /// IMG10 Implementação por interface
    /// </summary>
    public class FilterBookByCategory : IFilter
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

    /// <summary>
    /// IMG11 - Segunda versão da Interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    //public interface IFilter<T>
    //{
    //    public IList<T> Filter(List<T> list, Predicate<T> predicate);
    //}

    //IMG12
    //public abstract class FilterBook : IFilter<Book>
    //{
    //    public IList<Book> Filter(List<Book> list, Predicate<Book> predicate)
    //    {
    //        return list.Where(predicate.Invoke).ToList();
    //    }
    //}


    /// <summary>
    /// IMG13 - Terceira versão da Interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    //public interface IFilter<T>
    //{
    //    public IEnumerable<T> Filter(IEnumerable<T> list, Predicate<T> predicate);
    //}

    /// <summary>
    /// IMG14 - Terceira versão da Interface
    /// </summary>
    //public class FilterBookNovoFilter8 : IFilter<Book>
    //{
    //    public virtual IEnumerable<Book> Filter(IEnumerable<Book> list, Predicate<Book> predicate)
    //    {
    //        if (predicate == null)
    //        {
    //            throw new ArgumentNullException();
    //        }
    //        return list.Where(predicate.Invoke).ToList();
    //    }
    //}

    /// <summary>
    /// IMG15 - Quarta versão da Interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IFilter<T>
    {
        public IEnumerable<T> Filter(IEnumerable<T> list);
    }

    ///IMG16
    //public abstract class FilterBook : IFilter<Book>
    //{
    //    protected FilterBook()
    //    {
    //    }

    //    public virtual IEnumerable<Book> Filter(IEnumerable<Book> list)
    //    {
    //        Predicate<Book> predicate = GetPredicateFilter() ?? throw new Exception();
    //        return list.Where(predicate.Invoke).ToList();
    //    }

    //    protected abstract Predicate<Book> GetPredicateFilter();
    //}

    ///IMG17
    public abstract class FilterBook : IFilter<Book>
    {
        protected FilterBook()
        {
        }

        public virtual IEnumerable<Book> Filter(IEnumerable<Book> list)
        {
            Func<Book,bool> predicate = GetPredicateFilter();
            return list.Where(predicate).ToList();
        }

        protected abstract NonNullable<Func<Book, bool>> GetPredicateFilter();
    }


    ///// <summary>
    ///// 
    ///// </summary>
    //public class FilterBookNovoFilter4 : IFilter<Book>
    //{
    //    public IList<Book> Filter(List<Book> list, Predicate<Book> predicate)
    //    {
    //        return list.Where(predicate.Invoke).ToList();
    //    }
    //}



    //public class FilterBookNovoFilter5 : IFilter<Book>
    //{
    //    public IList<Book> Filter(List<Book> list, Predicate<Book> predicate)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //public interface IFilterList<T>
    //{
    //    public IList<T> Filter(List<T> list, Predicate<T> predicate);
    //}

    //public class FilterBookNovoFilter6 : IFilterList<Book>
    //{
    //    public IList<Book> Filter(List<Book> list, Predicate<Book> predicate)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}



    //public class FilterBookNovoFilter7 : IFilterEnumerable<Book>
    //{
    //    public IEnumerable<Book> Filter(IEnumerable<Book> list, Predicate<Book> predicate)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //public class FilterBookNovoFilter8 : IFilterEnumerable<Book>
    //{
    //    public virtual IEnumerable<Book> Filter(IEnumerable<Book> list, Predicate<Book> predicate)
    //    {
    //        if(predicate == null)
    //        {
    //            throw new ArgumentNullException();
    //        }
    //        return list.Where(predicate.Invoke).ToList();
    //    }
    //}

    //public interface IFilterEnumerable1<T>
    //{
    //    public IEnumerable<T> Filter(IEnumerable<T> list);
    //}

    //public class Teste : IFilterEnumerable<Book>
    //{
    //    public IEnumerable<Book> Filter(IEnumerable<Book> list, Predicate<Book> predicate)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //public abstract class FilterBookNovoFilter9 : IFilterEnumerable1<Book>
    //{
    //    protected FilterBookNovoFilter9()
    //    {
    //    }

    //    public virtual IEnumerable<Book> Filter(IEnumerable<Book> list)
    //    {
    //        Predicate<Book> predicate = GetPredicateFilter() ?? throw new Exception();
    //        return list.Where(predicate.Invoke).ToList();
    //    } 

    //    protected abstract Predicate<Book> GetPredicateFilter();
    //}


}
