using BookReviewAPI.Interfaces;
using BookRewiewAPI.Data;
using BookRewiewAPI.Models;

namespace BookReviewAPI.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context;
        }
        public bool CategoryExists(int id)
        {
            return _context.BookCategories.Any(c => c.CategoryId == id);
        }

        public ICollection<Book> GetBookByCategory(int categoryId)
        {
            return _context.BookCategories.Where(e=>e.CategoryId == categoryId).Select(c=>c.Book).ToList();
        }

        public ICollection<BookCategory> GetCategories()
        {
            return _context.BookCategories.ToList();
        }

        public BookCategory GetCategory(int id)
        {
            return _context.BookCategories.Where(e => e.CategoryId == id).FirstOrDefault();
        }
    }
}
