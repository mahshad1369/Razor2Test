namespace Razor2Test.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int? ParentCategoryId { get; set; }
        public Category ParentCategory { get; set; }
        public List<Category> Subcategories { get; set; }

        public Category()
        {
            var SubCategories = new List<Category>();
        }



    }
}
