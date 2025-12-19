using System.ComponentModel.DataAnnotations;

namespace HospitalAPI.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string FullName { get; set; }

        public required string Specialty { get; set; }

        public required string LicenseNumber { get; set; }
    }
}
