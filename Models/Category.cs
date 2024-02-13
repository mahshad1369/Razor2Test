namespace Razor2Test.Models
{
    public class Category
    {
        public int Id { get; internal set; }
        public string Title { get; set; }
        public string? PhotoPath { get; set; }
        public List<Product>? Products { get; set; }
    }
}
