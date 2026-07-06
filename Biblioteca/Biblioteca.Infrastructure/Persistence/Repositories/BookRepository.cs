using Biblioteca.Application.Ports.Out;
using Biblioteca.Domain.Entities;
using Biblioteca.Infrastructure.Persistence;
using Biblioteca.Infrastructure.Persistence.Entities;

namespace Biblioteca.Infrastructure.Persistence.Repositories
{
    public class BookRepository(BibliotecaDbContext context) : IBookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return context.Books.ToList()
                .Select(b => new Book(b.Id, b.Title, b.Author, b.Genre, b.PublicationYear, b.IsAvailable));
        }
    }
}