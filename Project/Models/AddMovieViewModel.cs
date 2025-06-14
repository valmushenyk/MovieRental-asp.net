using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class AddMovieViewModel
    {
        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Rental Price")]
        [Range(0.01, 100.00, ErrorMessage = "Price must be between $0.01 and $100.00")]
        public decimal RentalPrice { get; set; }

        [Required]
        [Display(Name = "Release Year")]
        [Range(1900, 2100, ErrorMessage = "Release year must be between 1900 and 2100")]
        public int ReleaseYear { get; set; }

        [Required]
        [StringLength(50)]
        public string Genre { get; set; }

        [Required]
        [Display(Name = "Duration (minutes)")]
        [Range(1, 600, ErrorMessage = "Duration must be between 1 and 600 minutes")]
        public int Duration { get; set; }
    }
} 