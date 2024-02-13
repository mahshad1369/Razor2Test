using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Razor2Test.Models;

namespace Razor2Test.Pages.Products
{
    public class EditDeleteModel : PageModel
    {
        private readonly IProductRepository productRepository;
        private readonly ICategoryRepository categoryRepository;

        public List<SelectListItem> Categories { get; set; }

        [BindProperty]
        public Product newProduct { get; set; }

        //[BindProperty(SupportsGet = true)]
        //public int Id { get; set; }

        //[BindProperty(SupportsGet = false)]
        //public int CategoryId { get; set; }

        public EditDeleteModel(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            this.productRepository = productRepository;
            this.categoryRepository = categoryRepository;
        }

        public IActionResult OnGet(int Id)
        {
            Categories = new();

            newProduct = productRepository.Get(Id);

            if (newProduct is null)
            {
                return NotFound();
            }

            Categories.AddRange(categoryRepository.GetAllCategories().Select(x => new SelectListItem()
            {
                Text = x.Title,
                Value = x.Id.ToString(),
                Selected = x.Id == newProduct.CategoryId
            }).ToList());



            return Page();
        }

        public IActionResult OnPost()
        {
            var checkProductExist = productRepository.ExistProduct(newProduct.Id);

            if (checkProductExist is false)
            {
                return NotFound();
            }

            productRepository.Update(newProduct);

            return RedirectToPage("./Index");
        }




    }
}
