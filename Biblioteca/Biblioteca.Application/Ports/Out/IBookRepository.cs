using Biblioteca.Domain.Entities;

namespace Biblioteca.Application.Ports.Out
{
    public interface IBookRepository 
    {
        //Book GetBookById(int id);
        IEnumerable<Book> GetBooks();
        //void AddBook(Book book);
        //void UpdateBook(Book book);
    }
}
