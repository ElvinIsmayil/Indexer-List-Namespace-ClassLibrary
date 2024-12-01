using PB503Helper;

namespace Indexer__List__Namespace__ClassLibrary.Models

{
    public class Book
    {
        private static int _counter;
        public int Id { get; private set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code { get; set; }
        

        public Book(string name)
        {
            Name = name;
            Id = ++_counter;
            Code = Helper.CreateBookCode(Name, Id);

        }

        public override string ToString()
        {
            return $"Id: {Id} , Name: {Name} , AuthorName: {AuthorName} , PageCount: {PageCount} , Code: {Code} ";
        }

    }
}
