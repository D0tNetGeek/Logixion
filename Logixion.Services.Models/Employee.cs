using System.ComponentModel.DataAnnotations;

namespace Logixion.Services.Models
{
    public class Employee
    {
        [Key]
        public virtual int Id { get; set; }
        [Required]
        [MaxLength(35)]
        public virtual string FirstName { get; set; }
        [Required]
        [MaxLength(35)]
        public virtual string LastName { get; set; }
        [Required]
        [MaxLength(500)]
        public virtual string Title { get; set; }
        [Required]
        public virtual string Achievements { get; set; }
    }
}
