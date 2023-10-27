using BookRewiewAPI.Data;
using BookRewiewAPI.Interfaces;
using BookRewiewAPI.Models;

namespace BookRewiewAPI.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _context;

        public BookRepository(DataContext context) 
        {
            _context = context;
        }

        public bool BookExists(int bookId)
        {
            throw new NotImplementedException();
        }

        public Book GetBook(int id)
        {
            return _context.Book.Where(p=>p.Id==id).FirstOrDefault();
        }

        public Book GetBook(string title)
        {
            return _context.Book.Where(p => p.Title == title).FirstOrDefault();
        }

        public decimal GetBookRating(int bookId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Book> GetBooks() 
        {
            return _context.Book.OrderBy(p => p.Id).ToList();
        }
    }
}
