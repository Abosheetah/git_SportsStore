namespace  SportsStoreApp.Models{
    public class Product{
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
    }
}