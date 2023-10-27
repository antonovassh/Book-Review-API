namespace BookRewiewAPI.Models
{
    public class Rewiewer
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public ICollection<Rewiew> Rewiews { get; set; }
    }
}
