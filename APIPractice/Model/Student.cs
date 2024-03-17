using System.ComponentModel.DataAnnotations;

namespace APIPractice.Model
{
    public class Student
    {
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string studentName { get; set; }
    }
}
