using BookRewiewAPI.Models;

namespace BookReviewAPI.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<BookCategory>GetCategories();
        BookCategory GetCategory(int id);
        ICollection<Book> GetBookByCategory(int categoryId);
        bool CategoryExists(int id);
        bool CreateCategory(Category category);
        bool Save();
    }
}
