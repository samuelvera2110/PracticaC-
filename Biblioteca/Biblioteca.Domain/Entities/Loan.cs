using Biblioteca.Domain.Exceptions;

namespace Biblioteca.Domain.Entities
{
    public class Loan
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public int BookId { get; private set; }
        public DateTime LoanDate { get; private set; }
        public DateTime? ReturnDate { get; private set; }

        public Loan(int userId, int bookId)
        {
            UserId = userId;
            BookId = bookId;
            LoanDate = DateTime.Now;
            ReturnDate = null;
        }

        public void Return()
        {
            if (ReturnDate is not null)
            {
                throw new CustomException("La fecha no puede ser vacia", null, null);
            }

            ReturnDate = DateTime.Now;
        }
    }
}
