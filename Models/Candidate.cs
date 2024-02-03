using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace kursKayit_MVC.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "E -Mail is Required")]
        public string? Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "FirstName is Required")]
        public string? FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "LastName is Required")]
        public string? LastName { get; set; } = string.Empty;
        public string? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        public string? SelectedCourse { get; set; } = string.Empty;
        public DateTime ApplyAt { get; set; }
        public Candidate() 
        {
            ApplyAt = DateTime.Now;
        }

    }
}
