using System.ComponentModel.DataAnnotations;

namespace Logixion.Domain.Entities
{
    public class UserDetail
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(25)]
        [Required]
        public string UserId { get; set; }
        [MaxLength(35)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(35)]
        [Required]
        public string LastName { get; set; }
        
    }
}
