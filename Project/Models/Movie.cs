using System;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        public decimal RentalPrice { get; set; }

        public bool IsAvailable { get; set; }

        [Display(Name = "Release Year")]
        public int ReleaseYear { get; set; }

        [Display(Name = "Genre")]
        public string Genre { get; set; }

        [Display(Name = "Duration (minutes)")]
        public int Duration { get; set; }
    }
} 