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
            return _context.Book.Any(p => p.Id == bookId);
        }

        public bool CreateBook(int ownerId, int categoryId, Book book)
        {
            var bookOwnerEntity = _context.Owners.Where(a => a.Id == ownerId).FirstOrDefault();
            var category = _context.Category.Where(a => a.Id == categoryId).FirstOrDefault();

            var bookOwner = new BookOwner()
            {
                Owner = bookOwnerEntity,
                Book = book,
            };

            _context.Add(bookOwner);
            var bookCategory = new BookCategory()
            {
                Category = category,
                Book = book
            };
            _context.Add(bookCategory);
            _context.Add(book);

            return Save();
        }

        public Book GetBook(int id)
        {
            return _context.Book.Where(p => p.Id == id).FirstOrDefault();
        }

        public Book GetBook(string title)
        {
            return _context.Book.Where(p => p.Title == title).FirstOrDefault();
        }

        public decimal GetBookRating(int bookId)
        {
            var review = _context.Reviews.Where(p => p.Book.Id == bookId);
            if (review.Count() <= 0)
                return 0;
            return (decimal)review.Sum(r => r.Rating) / review.Count();
        }

        public ICollection<Book> GetBooks()
        {
            return _context.Book.OrderBy(p => p.Id).ToList();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

    }
}
