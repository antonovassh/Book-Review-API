namespace BookRewiewAPI.Models
{
    public class BookOwner
    {
        public int BookId { get; set; }
        public int OwnerId { get; set; }
        public Book Book { get; set; }

        public Owner Owner { get; set; }
    }
}
