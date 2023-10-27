namespace BookRewiewAPI.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Country Country { get; set; }
        public ICollection<BookOwner> BookOwners { get; set; }
    }
}
