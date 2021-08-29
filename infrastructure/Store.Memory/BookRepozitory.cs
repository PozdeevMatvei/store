using System;
using System.Linq;

namespace Store.Memory
{
    public class BookRepozitory : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1,"King Arture"),
            new Book(2, "King Leo"),
            new Book(3, "Big Elephant")
        };
        public Book[] GetAllByTitle(string titlePart)
        {
            return books.Where(book => book.Title.Contains(titlePart)).ToArray();
        }
    }
}
