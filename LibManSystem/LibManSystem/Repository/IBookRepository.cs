using LibManSystem.Models;

namespace LibManSystem.Repository
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();

        List<Book> GetBooksAbove500();

        List<Book> SearchBook(string name);
    }
}
