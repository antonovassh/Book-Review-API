﻿namespace BookReviewAPI.Dto
{
    public class BookDto
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
