using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // LINQ Extension Methods

            // return just one object
            //var book = books.Single(b => b.Title == "ASP.NET MVC++"); //fails if book does not exist
            //Console.WriteLine(book.Title);

            //var book = books.SingleOrDefault(b => b.Title == "ASP.NET MVC++");
            //Console.WriteLine(book == null);

            var book = books.First(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(book.Title + " " + book.Price);
            
        }

        private static void OldWay()
        {
            var books = new BookRepository().GetBooks();

            var cheapBooks = new List<Book>();

            foreach (var book in books)
            {
                if (book.Price < 10)
                    cheapBooks.Add(book);
            }

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title + " " + book.Price);
            }
        }

        private static void NewWay()
        {
            var books = new BookRepository().GetBooks();

            // LINQ Query Operators
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;

            // LINQ Extension Methods
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book);
                //Console.WriteLine(book.Title + " " + book.Price);
            }
        }

    }
}
