namespace Razor2Test.Models;

public class Store
{
    public static List<Product> Products { get; set; } = new();
    public static List<Question> Questions { get; set; }=new();
    public static List<Comment> Comments { get; set; } = new();

    public static List<Category> Categories { get; set; } = new();

    public static List<Menu> Menus = new()
    {
        new Menu()
        {
            DisplayName = "Products",
            Url = "/Products/index"
        },
          new Menu()
        {
            DisplayName = "Categories",
            Url = "/Categories/index"
          },

    };
}


