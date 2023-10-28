using BookRewiewAPI.Interfaces;
using BookRewiewAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookRewiewAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Book>))]
        public IActionResult GetBooks()
        {
            var books = _bookRepository.GetBooks();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(books);
        }
        [HttpGet("{bookId}")]
        [ProducesResponseType(200,Type = typeof(Book))]
        [ProducesResponseType(400)]
        public IActionResult GetBook(int bookId) 
        { 
            if(!_bookRepository.BookExists(bookId))
                return NotFound();
            var book = _bookRepository.GetBook(bookId);
            if(!ModelState.IsValid) 
                return BadRequest(ModelState);
            return Ok(book);
        }
        [HttpGet("{bookId}/rating")]
        [ProducesResponseType(200, Type = typeof(decimal))]
        [ProducesResponseType(400)]
        public IActionResult GetBookRating(int bookId)
        {
            if(!_bookRepository.BookExists(bookId))
                return NotFound();
            var rating = _bookRepository.GetBookRating(bookId);
            if (!ModelState.IsValid)
                return BadRequest();
            return Ok(rating);
        }

    }
}
