using Biblioteca.Domain.Exceptions;

namespace Biblioteca.Domain.Entities
{
    public class User
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;

        public User(string name, string email)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new CustomException("Nombre no puede ser vacio", null, null);
            }
            if (string.IsNullOrEmpty(email))
            {
                throw new CustomException("Email no puede ser vacio", null, null);
            }

            Name = name;
            Email = email;
        }
    }
}
