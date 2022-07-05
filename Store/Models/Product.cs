namespace Store.Models
{
    public class Product:BaseEntity
    {
        public string? Product_category { get; set; }
        public int total_products { get; set; }
        public int TrendingProducts { get; set; }
    }
}
