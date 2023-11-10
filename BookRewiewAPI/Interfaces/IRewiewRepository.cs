using BookRewiewAPI.Models;

namespace BookReviewAPI.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review>GetReviews();
        Review GetReview(int reviewId);
        ICollection<Review> GetReviewsOfABook(int bookId);
        bool ReviewExists(int reviewId);
    }
}
