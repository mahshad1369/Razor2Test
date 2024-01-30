using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor2Test.Models;

namespace Razor2Test.Pages.Products
{
    public class ProductDetailsModel : PageModel
    {
        public Product Product{ get; set; }
       
    public IActionResult OnGet(int id)
        {
            if (id <= 4) 
            {
                Product = Store.Products.FirstOrDefault(x => x.Id == id);
                return Page();
            }
            return RedirectToPage("./SeeMore", new { id = id });
        }
    }
}
