using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor2Test.Models;
using System.Xml.Linq;

namespace Razor2Test.Pages.Products
{
    public class ProductDetailsModel : PageModel
    {
        private readonly IProductRepository productRepository;

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        [BindProperty(SupportsGet = false)]
        public Question Question { get; set; }

        [BindProperty(SupportsGet = false)]
        public Comment Comment { get; set; }

        [BindProperty(SupportsGet = false)]
        public Product Product { get; set; }

        public ProductDetailsModel(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult OnGet()
        {
            var product = productRepository.Get(Id);

            if (product is null)
            {
                return NotFound();
            }
            else
            {
                Product = product;
                return Page();
            }
        }

        public IActionResult OnPost()
        {

            var newProduct = productRepository.Get(Id);

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
