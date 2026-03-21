using System.ComponentModel.DataAnnotations;

namespace WebApplicationDevFinalProject.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; } = string.Empty;
        
        public string Genre { get; set; } = string.Empty;
        
        public int ReleaseYear { get; set; }
        
        public string Description { get; set; } = string.Empty;
    }
}