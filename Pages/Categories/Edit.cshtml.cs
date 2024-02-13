using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor2Test.Models;

namespace Razor2Test.Pages.Categories
{
    public class EditModel : PageModel
    {
        private readonly ICategoryRepository categoryRepository;

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        [BindProperty(SupportsGet = false)]
        public Category Category { get; set; }

        public EditModel(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IActionResult OnGet()
        {
            var category = categoryRepository.Get(Id);
            if (category is null)
            {
                return NotFound();
            }
            Category = category;
            return Page();
        }

        public IActionResult OnPost()
        {
            var categories = categoryRepository.GetAllCategories().ToList();
            var category = categoryRepository.Get(Id);
            if (category is null)
            {
                return NotFound();
            }

            category.Title = Category.Title;
            category.PhotoPath = Category.PhotoPath;
            return RedirectToPage("./Index");
        }
    }
}
