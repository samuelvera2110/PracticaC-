using Biblioteca.Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.API.Controllers
{
    [ApiController] 
    [Route("api/[controller]")] 
    public class BooksController : ControllerBase
    {
        private readonly GetBooksUseCase _getBooksUseCase;

        public BooksController(GetBooksUseCase getBooksUseCase)
        {
            _getBooksUseCase = getBooksUseCase;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var books = _getBooksUseCase.GetAllBooks();
            return Ok(books);
        }
    }
}
