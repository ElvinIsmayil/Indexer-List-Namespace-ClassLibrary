using System.Linq;

namespace Indexer__List__Namespace__ClassLibrary.Models
{
    public class Library
    {
        List<Book> books = new List<Book>();

        public Book this[int index]
        {
            get => books[index];
            
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public List<Book> FindAllBooksByName(string value)
        {

            var wantedBooks = books.FindAll(book => book.Name.ToLower() == value.ToLower());

            return wantedBooks;

        }

        public Book FindBookByCode(string code)
        {
            Book? book = books.Find(x => x.Code == code);
            return book;
        }
          

        public void RemoveAllBooksByName(string value)
        {
            books.RemoveAll(x => x.Name.ToLower().Contains(value.ToLower()));
        }

        public List<Book> SearchBooks(string value)
        {
            var searchedBooks = books.FindAll(x => x.Name.ToLower() == value.ToLower() || x.AuthorName.ToLower() == value.ToLower() || x.PageCount.ToString() == value.ToLower());
            return searchedBooks;        
        }



        public List<Book> FindAllBooksByPageCountRange(int minpagecount, int maxpagecount)
        {
            List<Book> wantedBooks = new List<Book>();
            wantedBooks = books.FindAll(x => x.PageCount > minpagecount && x.PageCount < maxpagecount);
            return wantedBooks;
        }

        public void RemoveBookByCode(string value)
        {
            var wanted = books.Find(x => x.Code == value);
            books.Remove(wanted);
        }

        public List<Book> GetBooks()
        {
            return books;
        }
    }
}
