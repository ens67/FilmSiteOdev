using System.ComponentModel.DataAnnotations;

namespace MovieArchiveApp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Film adı zorunludur.")]
        [Display(Name = "Film Adı")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Film türü zorunludur.")]
        [Display(Name = "Tür")]
        public string Genre { get; set; } = string.Empty;

        [Required(ErrorMessage = "Yönetmen adı zorunludur.")]
        [Display(Name = "Yönetmen")]
        public string Director { get; set; } = string.Empty;

        [Required(ErrorMessage = "Yayın yılı zorunludur.")]
        [Range(1888, 2100, ErrorMessage = "Geçerli bir yayın yılı giriniz.")]
        [Display(Name = "Yayın Yılı")]
        public int ReleaseYear { get; set; }

        [Required(ErrorMessage = "Puan zorunludur.")]
        [Range(0.0, 10.0, ErrorMessage = "Puan 0 ile 10 arasında olmalıdır.")]
        [Display(Name = "Puan (IMDb)")]
        public double Rating { get; set; }

        [Display(Name = "Afiş Resmi")]
        public string? ImagePath { get; set; }
    }
}