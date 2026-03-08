using LibManSystem.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LibManSystem.Controllers
{
    [Route("books")]
    public class BookController : Controller
    {
        private readonly IBookRepository repo;

        public BookController(IBookRepository repository)
        {
            repo = repository;
        }
        [HttpGet("all")]
        public IActionResult List()
        {
            var books = repo.GetAllBooks();
            return View(books);
        }

        public IActionResult ExpensiveBooks()
        {
            var books = repo.GetBooksAbove500();
            return View(books);
        }

        public IActionResult Search(string name)
        {
            var books = repo.SearchBook(name);
            ViewBag.Count = books.Count;
            return View(books);
        }
    }
}
