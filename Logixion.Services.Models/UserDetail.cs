using System.ComponentModel.DataAnnotations;

namespace Logixion.Services.Models
{
    public class UserDetail
    {
        [Key]
        public virtual int Id { get; set; }
        [MaxLength(25)]
        [Required]
        public virtual string UserId { get; set; }
        [MaxLength(35)]
        [Required]
        public virtual string FirstName { get; set; }
        [MaxLength(35)]
        [Required]
        public virtual string LastName { get; set; }
    }
}
