using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor2Test.Models;

namespace Razor2Test.Pages.Categories;

public class AddModel : PageModel
{
    private readonly ICategoryRepository categoryRepository;

    [BindProperty(SupportsGet = false)]
    public Category Category { get; set; }


    public AddModel(ICategoryRepository categoryRepository)
    {
        this.categoryRepository = categoryRepository;
        Category = new Category();
    }
    public void OnGet()
    {

    }
    public IActionResult OnPost()
    {
        if (ModelState.IsValid is false)
        {
            return Page();
        }

       
        if (categoryRepository.GetAllCategories().Any(x => x.Title.Trim().Equals(Category.Title)))
        {
            return Content("عنوان تکراریه");
        }
        categoryRepository.Add(Category);
        return RedirectToPage("/Categories/index");
    }
}
