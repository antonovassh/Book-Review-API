namespace BookRewiewAPI.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<Rewiew> Rewiews { get; set; }
        public ICollection<BookOwner> BookOwners { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }

    }
}
