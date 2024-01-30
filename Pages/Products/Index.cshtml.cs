using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor2Test.Models;

namespace Razor2Test.Pages.Products
{
    public class IndexModel : PageModel
    {
        public List<Product> Products { get; set; }
        public void OnGet()
        {
            Products = Store.Products;
        }


        public IActionResult OnGetDelete(int id)
        {
            var product = Store.Products.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            Store.Products.Remove(product);
            return RedirectToPage("./Index");

        }
    }
}
