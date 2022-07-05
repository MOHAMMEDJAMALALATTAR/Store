using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
