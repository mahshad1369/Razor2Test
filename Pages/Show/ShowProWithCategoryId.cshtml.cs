using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor2Test.Models;

namespace Razor2Test.Pages.Show
{
    public class ShowProWithCategoryIdModel : PageModel
    {
        public List<Product> products{ get; set; }
        public void OnGet(int id)
        {
            products = Store.Products.Where(x => x.CategoryId == id).ToList();
        }
    }
}
