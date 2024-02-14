using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor2Test.Models;
using Razor2Test.ViewModel;
using System.Reflection;

namespace Razor2Test.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly IProductRepository productRepository;

        public int PageIndex { get; set; }
        //public int TotalPages { get; set; }
        public PaginationModel<List<Product>> paginationModels { get; set; }




        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public List<Product> Products { get; set; }
        public List<Product> Products2 { get; set; } = new();

        public IndexModel(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }


        public void OnGet(string? sortOrder)
        {
            Products2 = productRepository.GetAllProduct().ToList();
            List<Product> products = new();

            

            //products = productRepository.GetAllProduct().ApplyPagination(1, 10).Items.ToList();

            if (string.IsNullOrWhiteSpace(sortOrder) == false)
            {
                products = ApplySorting(sortOrder, products);

                if (sortOrder.Equals("Name-Asc"))
                {
                    NameSort = "Name-Desc";
                }
                else if (sortOrder.Equals("Name-Desc"))
                {
                    NameSort = "Name-Asc";
                }
                else if (sortOrder.Equals("Date-Desc"))
                {
                    DateSort = "Date-Asc";
                }
                else if (sortOrder.Equals("Date-Asc"))
                {
                    DateSort = "Date-Desc";
                }

            }
            else
            {
                products = productRepository.GetAllProduct().ToList();
                NameSort = "Name-Asc";
                DateSort = "Date-Asc";
            }

            Products = products;
        }


        //function for sorting
        private static List<Product> ApplySorting(string sortOrder, List<Product> products)
        {
            bool IsAscSorting = sortOrder.ToLower().EndsWith("asc") ? true : false;

            if (sortOrder.ToLower().StartsWith("name"))
            {
                if (IsAscSorting)
                {
                    products = Store.Products.OrderBy(x => x.Title).ToList();
                }
                else
                {
                    products = Store.Products.OrderByDescending(x => x.Title).ToList();
                }
            }
            else if (sortOrder.ToLower().StartsWith("date"))
            {
                if (IsAscSorting)
                {
                    products = Store.Products.OrderBy(x => x.CreationDate).ToList();
                }
                else
                {
                    products = Store.Products.OrderByDescending(x => x.CreationDate).ToList();
                }
            }

            return products;
        }

        public IActionResult OnGetDelete(int id)
        {
            var product = productRepository.ExistProduct(id);
            if (product is false)
            {
                return NotFound();
            }

            productRepository.Delete(id);
            return RedirectToPage("./Index");

        }
    }
}
