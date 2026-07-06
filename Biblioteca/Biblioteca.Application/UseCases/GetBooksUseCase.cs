
using Biblioteca.Application.Ports.Out;
using Biblioteca.Domain.Entities;

namespace Biblioteca.Application.UseCases
{
    public class GetBooksUseCase
    {
        private readonly IBookRepository _bookRepository;
        public GetBooksUseCase(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _bookRepository.GetBooks();
        }
    }
}
