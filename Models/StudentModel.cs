using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_demo.Models
{
    public class StudentModel
    {
        [Key]
        [Column("Rollno")]
        public int Id { get; set; }

        [Column("StudentName", TypeName ="varchar(50)")]
        public string Name { get; set; }

        [Column("StudentGender",TypeName ="varchar(10)")]
        public string Gender { get; set; }

        public int? Age { get; set; }
        public int? Standard { get; set; }
    }
}
