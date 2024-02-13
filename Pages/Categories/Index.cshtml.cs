using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor2Test.Models;

namespace Razor2Test.Pages.Categories;

public class IndexModel : PageModel
{
    private readonly ICategoryRepository categoryRepository;

    public List<Category> Categories { get; set; }
    public IndexModel(ICategoryRepository categoryRepository)
    {
        this.categoryRepository = categoryRepository;
    }

    public void OnGet()
    {
        Categories = categoryRepository.GetAllCategories().ToList();
    }

    public IActionResult OnGetDelete(int id)
    {
        var category = categoryRepository.Get(id);

        if (category is null)
        {
            return NotFound();
        }
        categoryRepository.Delete(id);
        return RedirectToPage("./Index");
    }
}
