using System.ComponentModel.DataAnnotations;

namespace HospitalAPI.Models
{
    public class NewBaseType
    {
        [Required]
        public required string Email { get; set; }
    }

    public class User : NewBaseType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Username { get; set; }

        [Required]
        public required string PasswordHash { get; set; }

        public bool IsActive { get; set; } = true;

        public User(bool isActive)
        {
            IsActive = isActive;
        }
    }
}
