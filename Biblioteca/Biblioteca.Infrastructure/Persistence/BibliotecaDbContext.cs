using Biblioteca.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Infrastructure.Persistence
{
    public class BibliotecaDbContext : DbContext
    {
        public BibliotecaDbContext(DbContextOptions<BibliotecaDbContext> options) : base(options)
        {

        }

        public DbSet<BookEntity> Books { get; set; }
    }
}
