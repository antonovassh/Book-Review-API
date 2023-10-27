namespace BookRewiewAPI.Models
{
    public class Rewiew
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Text { get; set; }
        public Rewiewer Rewiewer { get; set; }
        public Book Book { get; set; }
    }
}
