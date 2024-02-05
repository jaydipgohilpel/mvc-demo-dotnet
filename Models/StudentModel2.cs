using System.ComponentModel.DataAnnotations;

namespace mvc_demo.Models
{
    public class StudentModel2
    {
        public int rollNo { get; set; }
        
        [Required]
        public string name { get; set; }

        [Required(ErrorMessage = "Gender Must be Required")]
        [StringLength(8)]
        public string gender { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [Range(10,50)]
        public int? age { get; set; }
        public int standard { get; set; }

        [Required]
        [RegularExpression("(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$")]
        [StringLength(8, MinimumLength = 6)]
        public int password { get; set; }
    }
}
