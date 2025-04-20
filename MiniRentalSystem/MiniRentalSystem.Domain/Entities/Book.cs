// Title: Book.cs
// Author: Ahmed Ibrahim
// Date: 2025-04-15
// Description: Represents a book entity with detailed metadata for rental system.

// Ignore Spelling: ISBN

using System.ComponentModel.DataAnnotations;

namespace MiniRentalSystem.Domain.Entities
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Title")]
        public string Title { get; set; } = string.Empty;

        [MaxLength(100)]
        [Display(Name = "Author Name")]
        public string Author { get; set; } = string.Empty;

        [Display(Name = "Published Date")]
        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; }

        [MaxLength(50)]
        [Display(Name = "Publisher")]
        public string Publisher { get; set; } = string.Empty;

        [MaxLength(20)]
        [Display(Name = "ISBN")]
        public string ISBN { get; set; } = string.Empty;

        [Range(1, 10000)]
        [Display(Name = "Total Pages")]
        public int PageCount { get; set; }

        [Display(Name = "Language")]
        [MaxLength(50)]
        public string Language { get; set; } = "English";

        [Display(Name = "Genre")]
        [MaxLength(100)]
        public string Genre { get; set; } = string.Empty;

        [Display(Name = "Is Available")]
        public bool IsAvailable { get; set; } = true;

        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Display(Name = "Last Updated")]
        public DateTime? UpdatedAt { get; set; }
    }
}