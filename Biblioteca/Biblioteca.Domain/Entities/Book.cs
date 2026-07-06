using Biblioteca.Domain.Exceptions;
using static Biblioteca.Domain.Constants.Messages;
using static Biblioteca.Domain.Constants.Codes;

namespace Biblioteca.Domain.Entities
{
    public class Book
    {
        public int Id { get; private set; }
        public string Title { get; private set; } = string.Empty;
        public string Author { get; private set; } = string.Empty;
        public string? Genre { get; private set; }
        public int? PublicationYear { get; private set; }
        public bool IsAvailable { get; private set; }
        public Book(int Id, string Title, string Author, string? Genre, int? PublicationYear, bool IsAvailable)
        {
            if (string.IsNullOrEmpty(Title))
            {
                throw new CustomException("El titulo no puede estar vacio", null, null);
            }
            if (string.IsNullOrEmpty(Author))
            {
                throw new CustomException("El autor no puede estar vacio", null, null);
            }
            this.Id = Id;
            this.Title = Title;
            this.Author = Author;
            this.Genre = Genre;
            this.PublicationYear = PublicationYear;
            this.IsAvailable = IsAvailable;
        }
        public void MarkAsLoan()
        {
            if (!IsAvailable)
            {
                throw new CustomException(BOOK_ON_LOAN, null, BOOK_ON_LOAN_CODE);
            }
            IsAvailable = false;
        }
        public void MarkAsAvailable()
        {
            IsAvailable = true;
        }
    }
}
