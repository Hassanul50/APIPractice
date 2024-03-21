using System.ComponentModel.DataAnnotations;

namespace APIPractice.Model
{
    public class Student
    {
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string studentName { get; set; }
        public string  FatherName { get; set; }     
        public string  MotherName { get; set; }     
        public DateTime Dob { get; set; }     
        public string  Address { get; set; }     
        public string Email { get; set; }
        public int NId { get; set; }     
    }
}
