using System;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 12321-32131", "D. Knuth", "Art of programming", 
                    "desctription", 7m),
            new Book(2, "ISBN 12321-32132", "M. Fowler", "Refactoring",
                    "description", 11m),
            new Book(3, "ISBN 12321-32133", "B. Kernighan D. Ritchie", "C programming Language",
                    "description", 14m)
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn)
                        .ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Author.Contains(query) 
                                    || book.Title.Contains(query))
                        .ToArray();
        }

        Book IBookRepository.GetById(int id)
        {
            return books.Single(book => book.Id == id);
        }
    }
}
