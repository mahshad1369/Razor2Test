using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor2Test.Models;

namespace Razor2Test.Pages.Products
{
    public class EditDeleteModel : PageModel
    {
        [BindProperty(SupportsGet = false)]
        public Product newProduct { get; set; } 

        [BindProperty(SupportsGet =true)]
        public int Id { get; set; }

        public IActionResult OnGet()
        {
            var product = Store.Products.FirstOrDefault(x => x.Id == Id);
            if (product == null)
            {
                return NotFound();
            }
            newProduct = product;
            return Page();
        }

        public IActionResult OnPost()
        {
            var products=Store.Products.ToList();
            var product = products.FirstOrDefault(x => x.Id == Id);
            if (product == null)
            {
                return NotFound();
            }

            product.Title= newProduct.Title;
            product.ShortDescription= newProduct.ShortDescription;
            product.LongDescription= newProduct.LongDescription;
            return RedirectToPage("./Index");
        }

        
       

    }
}
