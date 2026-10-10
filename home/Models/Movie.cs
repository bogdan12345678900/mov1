using System.ComponentModel.DataAnnotations;

namespace KinopoiskClone.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = string.Empty;
        
        [Required]
        public int Year { get; set; }
        
        public string PosterUrl { get; set; } = string.Empty;
        
        [MaxLength(1000)]
        public string Description { get; set; } = string.Empty;
    }
}