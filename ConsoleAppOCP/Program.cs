using Combinatorics.Collections;
using SOLID.OCP;
using SOLID.OCP.AtendeOCP;
using SOLID.OCP.AtendeOCP.Interfaces;
using SOLID.OCP.ExtensionMethods;
using SOLID.OCP.Models;
using SOLID.OCP.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppOCP
{
    class Program
    {
        private static List<Book> BooksToFilter;

        static void Main(string[] args)
        {
            InitializeListBooks();
            Sample();

            //var filterCategory = new FilterBook_V1();
            //var resultCategory = filterCategory.Filter(BooksToFilter, b => b.TypeCategory.Equals(TypeCategory.Philosophy));
            //var filterCategoryLanguage = new FilterBook_V1();
            //var resultCategoryLanguage = filterCategoryLanguage.Filter(BooksToFilter, b => b.TypeCategory.Equals(TypeCategory.Philosophy) &&
            //b.TypeLanguage.Equals(TypeLanguage.FR));
        }

        private static void Sample()
        {
            OCPWithAbstractClass();
            OCPWithInterface();
            OCPWithExtensionMethods();
            OCPWithAbstractClassAndSpecification();

            Console.ReadKey();
        }

        private static void OCPWithExtensionMethods()
        {
            var resultCategory = new FilterBookWithoutOCP_V1().FilterByCategory(BooksToFilter, TypeCategory.Philosophy);
            var resultLanguage = new FilterBookWithoutOCP_V1().FilterByLanguage(BooksToFilter, TypeLanguage.EN);

            Console.WriteLine(
                string.Format("Princípio OCP aplicado utilizando Extension Methods, {0} items encontrados para a categoria Filosofy, {1} items encontrados para o idioma EN",
                resultCategory.Count().ToString(), 
                resultLanguage.Count().ToString())
                );
        }

        private static void OCPWithInterface()
        {
            IFilter_V1 filterLanguage = new FilterBookByLanguage(TypeLanguage.EN);
            IFilter_V1 filterCategory = new FilterBookByCategory(TypeCategory.Philosophy);
            var resultLanguage = filterLanguage.Filter(BooksToFilter);
            var resultCategory = filterCategory.Filter(BooksToFilter);

            Console.WriteLine(
                string.Format("Princípio OCP não violado utilizando interfaces, {0} items encontrados para a categoria Filosofy, {1} items encontrados para o idioma EN",
                resultCategory.Count().ToString(),
                resultLanguage.Count().ToString())
                );
        }

        private static void OCPWithAbstractClassAndSpecification()
        {
            var filterSpec = new FilterBooks();
            var resultLanguage = filterSpec.Filter(BooksToFilter, 
                new BookLanguageSpecification(TypeLanguage.EN)).ToList();
            var resultCategory = filterSpec.Filter(BooksToFilter, 
                new BookCategorySpecification(TypeCategory.Philosophy)).ToList();

            Console.WriteLine(
                string.Format("Princípio OCP aplicado utilizando Abstract Class e Specification, {0} items encontrados para a categoria Filosofy, {1} items encontrados para o idioma EN",
                resultCategory.Count().ToString(),
                resultLanguage.Count().ToString())
                );
        }

        private static void OCPWithAbstractClass()
        {
            FilterBook filterLanguage = new FilterByLanguage(TypeLanguage.EN);
            IEnumerable<Book> result = filterLanguage.Filter(BooksToFilter);

            FilterBook filterBy = new FilterByPredicate(x => x.TypeCategory.Equals(TypeCategory.Philosophy));
            IEnumerable<Book> result3 = filterBy.Filter(BooksToFilter);

            Console.WriteLine(
                string.Format("Princípio OCP aplicado utilizando Abstract Class, {0} items encontrados para a categoria Filosofy, {1} items encontrados para o idioma EN",
                result3.Count().ToString(),
                result.Count().ToString())
                );
        }

        private static void InitializeListBooks()
        {
            Random rnd = new Random();

            List<Book> books = new List<Book>();

            books.Add(new Book { Rate = rnd.Next(100), TypeCategory = TypeCategory.Philosophy, TypeLanguage = TypeLanguage.EN, TypePrint = TypePrint.BW });
            books.Add(new Book { Rate = rnd.Next(100), TypeCategory = TypeCategory.History, TypeLanguage = TypeLanguage.PT, TypePrint = TypePrint.Color });
            books.Add(new Book { Rate = rnd.Next(100), TypeCategory = TypeCategory.Romance, TypeLanguage = TypeLanguage.FR, TypePrint = TypePrint.BW });
            books.Add(new Book { Rate = rnd.Next(100), TypeCategory = TypeCategory.Tecnology, TypeLanguage = TypeLanguage.EN, TypePrint = TypePrint.Color });
            books.Add(new Book { Rate = rnd.Next(100), TypeCategory = TypeCategory.Philosophy, TypeLanguage = TypeLanguage.PT, TypePrint = TypePrint.BW });
            books.Add(new Book { Rate = rnd.Next(100), TypeCategory = TypeCategory.History, TypeLanguage = TypeLanguage.PT, TypePrint = TypePrint.Color });
            books.Add(new Book { Rate = rnd.Next(100), TypeCategory = TypeCategory.Philosophy, TypeLanguage = TypeLanguage.EN, TypePrint = TypePrint.BW });
            books.Add(new Book { Rate = rnd.Next(100), TypeCategory = TypeCategory.Philosophy, TypeLanguage = TypeLanguage.PT, TypePrint = TypePrint.Color });
            books.Add(new Book { Rate = rnd.Next(100), TypeCategory = TypeCategory.Romance, TypeLanguage = TypeLanguage.FR, TypePrint = TypePrint.BW });


            Permutations<Book> combinations = new Permutations<Book>(books);

            BooksToFilter = combinations.SelectMany(x => x).ToList();
        }
    }
}
