using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAdvancedDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // args => expression
            // "args goes to expression"
            // or "args such that <expression>"
            //number => number*number

            // Func<int, int> : int1 = param in from Square, int2 = return value
            // usage: System.Func <in T, out TResult>
            Func<int, int> square = number => number * number;
            // use number such that number is multiplied times number

            // so here, 5 becomes our "in T", and the printed result is our "TResult"
            Console.WriteLine(square(5));
            Console.WriteLine(Square(5));


            const int factor = 5;

            Func<int, int> multiplier = n => n * factor;

            var result = multiplier(10);

            Console.WriteLine(result);

            var books = new BookRepository().GetBooks();

            //FindAll takes a "predicate" as an argument--basically a method returning true/false for each object in list
            //First example, using standard method
            var cheapBooks = books.FindAll(IsCheaperThan10Dollars);

            Console.WriteLine("Cheap books: ");
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

            //rewritten as lambda expression
            var expensiveBooks = books.FindAll(book => book.Price > 10);

            Console.WriteLine("Expensive books: ");
            foreach (var book in expensiveBooks)
            {
                Console.WriteLine(book.Title);
            }


        }

        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }


        static int Square(int number)
        {
            return number * number;
        }


    }
}
