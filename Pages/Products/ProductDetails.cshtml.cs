using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor2Test.Models;
using System.Xml.Linq;

namespace Razor2Test.Pages.Products
{
    public class ProductDetailsModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        [BindProperty(SupportsGet =false)]
        public Question Question{ get; set; }

        [BindProperty(SupportsGet =false)]
        public Comment Comment{ get; set; }

        [BindProperty(SupportsGet = false)]
        public Product Product{ get; set; }
       
        public IActionResult OnGet(int id)
        {
            var newProduct = Store.Products.FirstOrDefault(x => x.Id == id);

            if (newProduct == null)
            {
                return NotFound();
            }
            else
            {
                Product = newProduct;
                return Page();
            }
        }

        public IActionResult OnPost()
        {

            var newProduct = Store.Products.FirstOrDefault(x => x.Id == Id);
           
            if (newProduct.Comments is null)
                newProduct.Comments = new();
            newProduct.Comments.Add(Comment);

            if (newProduct.Questions is null)
                newProduct.Questions = new();
            newProduct.Questions.Add(Question);
            return RedirectToPage("/Products/ProductDetails", new { id = Id });
        }
    }
}
