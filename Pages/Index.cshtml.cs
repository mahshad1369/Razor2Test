using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor2Test.Models;
using Razor2Test.ViewModel;

namespace Razor2Test.Pages
{
    public class IndexModel : PageModel
    {
        public HomeViewModel HomeViewModel { get; set; } = new HomeViewModel();
        public void OnGet()
        {
            HomeViewModel.CategoriesViewModel = Store.Categories.Select(x => new CategoryViewModel
            {
                Id = x.Id,
                PhotoPath = x.PhotoPath,
                Title = x.Title,
            }).ToList();
        }
    }
}
