using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Buyer:BaseEntity
    {
        public int? CardNumber { get; set; }
        [Required]
        public string Address { get; set; }

    }
}
