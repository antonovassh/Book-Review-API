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

        public bool CreateCategory(Category category)
        {
            
            _context.Add(category);
            _context.SaveChanges();
            return Save();
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

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
