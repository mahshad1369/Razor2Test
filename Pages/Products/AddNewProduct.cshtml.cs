using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor2Test.Models;

namespace Razor2Test.Pages.Products
{
    public class AddNewProductModel : PageModel
    {
        [BindProperty(SupportsGet = false)]
        public Product newProduct { get; set; }

        public List<Product> newProducts1 = new List<Product>();

        public void OnGet()
        {  
           
        }
        public AddNewProductModel()
        {
            newProduct = new Product();
        }


        public IActionResult OnPost() 
        {
            if (ModelState.IsValid==false)
            {
                return Page();
            }
            int count=Store.Products.Count();
            newProduct.Id = count+2;
            Store.Products.Add(newProduct);
            return RedirectToPage("./Index");
        }
        
    }
}
