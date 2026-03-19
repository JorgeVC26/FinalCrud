using System.ComponentModel.DataAnnotations;

namespace FinalCrud.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Range(18, 100)]
        public int Age { get; set; }
    }
}