using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor2Test.Models;

namespace Razor2Test.Pages.Categories;

public class IndexModel : PageModel
{
    
    public List<Category> Categories { get; set; }
    public void OnGet()
    {
        Categories = Store.Categories;
    }

    public IActionResult OnPostDelete(int id)
    {
        var category = Store.Categories.FirstOrDefault(x => x.Id == id);

        if (category is null)
        {
            return NotFound();
        }
        Store.Categories.Remove(category);
        return Page();
    }
}
