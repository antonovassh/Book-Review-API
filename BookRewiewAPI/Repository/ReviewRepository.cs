using AutoMapper;
using BookReviewAPI.Interfaces;
using BookRewiewAPI.Data;
using BookRewiewAPI.Models;

namespace BookReviewAPI.Repository
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ReviewRepository (DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool CreateReview(Review review)
        {
            _context.Add(review);
            return Save();
        }

        public bool CreateReview(Review review, int bookId, int reviewerId)
        {
            throw new NotImplementedException();
        }

        public Review GetReview(int reviewId)
        {
            return _context.Reviews.Where(r=>r.Id==reviewId).FirstOrDefault();  
        }

        public ICollection<Review> GetReviews()
        {
            return _context.Reviews.ToList();
        }

        public ICollection<Review> GetReviewsOfABook(int bookId)
        {
            return _context.Reviews.Where(r=>r.Book.Id==bookId).ToList();
        }

        public bool ReviewExists(int reviewId)
        {
            return _context.Reviews.Any(r=>r.Id==reviewId);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;    
        }
    }
}
