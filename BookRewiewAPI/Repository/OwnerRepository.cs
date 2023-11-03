using BookReviewAPI.Interfaces;
using BookRewiewAPI.Data;
using BookRewiewAPI.Models;

namespace BookReviewAPI.Repository
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly DataContext _context;

        public OwnerRepository(DataContext context)
        {
            _context = context;
        }
        public ICollection<Book> GetBookByOwner(int ownerId)
        {
            return _context.BookOwners.Where(p=>p.Book.Id == ownerId).Select(p=>p.Book).ToList();
        }

        public Owner GetOwner(int ownerId)
        {
            return _context.Owners.Where(o => o.Id == ownerId).FirstOrDefault();
        }

        public ICollection<Owner> GetOwnerOfBook(int bookId)
        {
            return _context.BookOwners.Where(p => p.Book.Id == bookId).Select(o => o.Owner).ToList();
        }

        public ICollection<Owner> GetOwners()
        {
            return _context.Owners.ToList();
        }

        public bool OwnerExist(int ownerId)
        {
            return _context.Owners.Any(o=> o.Id == ownerId);
        }
    }
}
