using Indexer__List__Namespace__ClassLibrary.Models;

namespace Indexer__List__Namespace__ClassLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Book book1 = new Book("Programming")
            {
                AuthorName = "Elvin",
                PageCount = 150
            };
            Book book2 = new Book("Programming")
            {
                AuthorName = "Elvin",
                PageCount = 200
            };
            Book book3 = new Book("Cooking")
            {
                AuthorName = "Sarah",
                PageCount = 300
            };

            
         
            Library library = new Library();

            
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            var booksByName = library.FindAllBooksByName("coOkinG");

            booksByName.ForEach(x => Console.WriteLine(x));

            var bookByCode = library.FindBookByCode("PR1");

            Console.WriteLine(bookByCode);


            library.RemoveAllBooksByName("co");

            var books = library.GetBooks();

            books.ForEach(x=> Console.WriteLine(x));

            var searchedBooks = library.SearchBooks("150");

            searchedBooks.ForEach(x => Console.WriteLine(x));


            var booksByPageCountRange = library.FindAllBooksByPageCountRange(50, 250);

            booksByPageCountRange.ForEach(x => Console.WriteLine(x));

            library.RemoveBookByCode("PR2");

            var books2 = library.GetBooks();

            books2.ForEach(x => Console.WriteLine(x));
           

        }
    }
}
