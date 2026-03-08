using LibManSystem.Models;

namespace LibManSystem.Repository
{
    public class ListBookRepository : IBookRepository
    {
        List<Book> books = new List<Book>()
        {
            new Book { Id=1, Name="Java", Author="James", Price=600 },
            new Book { Id=2, Name="CSharp", Author="Anders", Price=700 },
            new Book { Id=3, Name="Python", Author="Guido", Price=450 },
            new Book { Id=4, Name="Data Science", Author="Andrew", Price=800 }
        };

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public List<Book> GetBooksAbove500()
        {
            return books.Where(b => b.Price > 500).ToList();
        }

        public List<Book> SearchBook(string name)
        {
            return books.Where(b => b.Name.ToLower().Contains(name.ToLower())).ToList();
        }
    }
}
