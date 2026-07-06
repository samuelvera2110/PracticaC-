using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Infrastructure.Persistence.Entities
{
    [Table("Books")]
    public class BookEntity
    {
        public BookEntity(string title, string author, string? genre, int? publicationYear, bool isAvailable)
        {
            Title = title;
            Author = author;
            Genre = genre;
            PublicationYear = publicationYear;
            IsAvailable = isAvailable;
        }
        public int Id { get; set; }

        [Required]
        [Column("Title", TypeName = "nvarchar(200)")]
        [MaxLength(200)]
        public string Title { get; set; } = null!;

        [Required]
        [Column("Author", TypeName = "nvarchar(150)")]
        [MaxLength(150)]
        public string Author { get; set; } = null!;

        [Column("Genre", TypeName = "nvarchar(100)")]
        [MaxLength(100)]
        public string? Genre { get; set; }

        [Column("PublicationYear")]
        public int? PublicationYear { get; set; }

        [Required]
        [Column("IsAvailable")]
        public bool IsAvailable { get; set; }
    }
}
