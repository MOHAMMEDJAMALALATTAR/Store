namespace Store.Models
{
    public class Seller:BaseEntity
    {
        public Product Product { get; set; }
        public int? MonthlySales { get; set; }
        public int? dailySales { get; set; }
        public int? Invoices { get; set; }

    }
}
