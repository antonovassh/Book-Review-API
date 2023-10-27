using BookRewiewAPI.Data;
using BookRewiewAPI.Models;

namespace BookRewiewAPI
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.BookOwners.Any())
            {
                var bookOwners = new List<BookOwner>()
                {
                    new BookOwner()
                    {
                        Book = new Book()
                        {
                            Title = "The Great Gatsby",
                            Author = "F. Scott Fitzgerald",
                            CreatedDate = new DateTime(1925),
                            BookCategories = new List<BookCategory>()
                            {
                                new BookCategory { Category = new Category() { Name = "Novel"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="The Great Gatsby",Text = "\"The Great Gatsby\" by F. Scott Fitzgerald is a timeless classic that" +
                                " delves into the extravagance and moral decay of the Roaring Twenties, vividly capturing the American Dream's elusive" +
                                " allure and its ultimate hollowness.", 
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title="The Great Gatsby", Text = "I didn't enjoy \"The Great Gatsby\" because it felt like a lot of rich " +
                                "people's drama with characters I couldn't relate to.", 
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title="The Great Gatsby",Text = "I loved \"The Great Gatsby\" for its captivating portrayal of the glitzy Jazz" +
                                " Age and the complex characters, ", 
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Jack",
                            LastName = "Tusk",
                            Country = new Country()
                            {
                                Name = "USA"
                            }
                        }
                    },
                    new BookOwner()
                    {
                        Book = new Book()
                        {
                            Title = "Hamlet",
                            Author = "William Shakespear",
                            CreatedDate = new DateTime(1601),
                            BookCategories = new List<BookCategory>()
                            {
                                new BookCategory { Category = new Category() { Name = "Play"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title= "Hamlet", Text = "I liked \"Hamlet\" because it had a lot of action and some funny parts, even though" +
                                " it's also pretty sad.", 
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title= "Hamlet",Text = "I found \"Hamlet\" to be a bit of a rollercoaster – the mix of intense drama, dark humor," +
                                " and psychological depth.", 
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title= "Hamlet", Text = "\"Hamlet\" is a classic that never ceases to amaze me. Its exploration of revenge and the" +
                                " human psyche evoked a profound sense of awe, leaving me emotionally stirred and intellectually engaged.",
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "John",
                            LastName = "Doe",
                            Country = new Country()
                            {
                                Name = "UK"
                            }
                        }
                    },
                                    new BookOwner()
                    {
                        Book = new Book()
                        {
                            Title = "Pride and Prejudice",
                            Author = "Jane Austen",
                            CreatedDate = new DateTime(1813),
                            BookCategories = new List<BookCategory>()
                            {
                                new BookCategory { Category = new Category() { Name = "Romance"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Pride and Prejudice",Text = "\"Pride and Prejudice\" is a heartwarming classic that had me rooting for Elizabeth" +
                                " and Mr. Darcy's love story from start to finish.", 
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title="Pride and Prejudice",Text = "I didn't expect to enjoy a 19th-century novel, but \"Pride and Prejudice\" surprised" +
                                " me with its lively characters and romantic twists.", 
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title="Pride and Prejudice",Text = "\"Pride and Prejudice\" is a delightful book that whisked me away to another era, and I" +
                                " couldn't help but get swept up in the charming world of manners and matchmaking.", 
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Helen",
                            LastName = "Johnson",
                            Country = new Country()
                            {
                                Name = "Germany"
                            }
                        }
                    }
                };
                dataContext.BookOwners.AddRange(bookOwners);
                dataContext.SaveChanges();
            }
        }
    }
}
