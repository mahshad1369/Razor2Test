using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor2Test.Models;
using Razor2Test.ViewModel;

namespace Razor2Test.Pages.Products.Show
{
    public class ShowByIdModel : PageModel
    {
        private readonly IProductRepository productRepository;

        public HomeViewModel HomeViewModel { get; set; } = new HomeViewModel();

        public ShowByIdModel(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public void OnGet(int id)
        {
            HomeViewModel.ProductsViewModel = productRepository.GetProductsByCategoryId(id).Select(x => new ProductViewModel
            {
                Title = x.Title,
                PhotoPath = x.PhotoPath,
            }).ToList();

        }
    }
}
