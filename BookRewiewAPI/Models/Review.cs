namespace BookRewiewAPI.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Text { get; set; }
        public int Rating { get; set; }
        public int BookId { get; set; }
        public int ReviewerId { get; set; }
        public Reviewer Reviewer { get; set; }
        public Book Book { get; set; }
    }
}
