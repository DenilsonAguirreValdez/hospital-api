using System.ComponentModel.DataAnnotations;

namespace HospitalAPI.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string FullName { get; set; }

        [Required]
        public required string DNI { get; set; }

        public DateTime BirthDate { get; set; }

        public required string Gender { get; set; }
    }
}
