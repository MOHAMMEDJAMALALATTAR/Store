namespace Store.Models
{
    public class Supplier:BaseEntity
    {
        public Seller Number_Sellers { get; set; }
        public Product Product { get; set; }

    }
}
