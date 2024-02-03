using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor2Test.Models;

namespace Razor2Test.Pages.Categories;

public class AddModel : PageModel
{
    [BindProperty(SupportsGet = false)]
    public Category Category { get; set; }


    public AddModel()
    {
        Category = new Category();
    }
    public void OnGet()
    {

    }
    public IActionResult OnPost()
    {
        if (ModelState.IsValid == false)
        {
            return Page();
        }

        if (Store.Categories.Any(x => x.Title.Trim().Equals(Category.Title)))
        {
            return Content("عنوان تکراریه");
        }
        //var maxId = Store.Categories.Max(x => x.Id);
        Category.Id = Store.Categories.Count + 1;
        Store.Categories.Add(Category);
        return RedirectToPage("/Categories/index");
    }
}
