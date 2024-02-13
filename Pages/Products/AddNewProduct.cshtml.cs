using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Razor2Test.Models;
using Razor2Test.ViewModel;
using System.Collections.Generic;

namespace Razor2Test.Pages.Products;

public class AddNewProductModel : PageModel
{
    [BindProperty(SupportsGet = false)]
    public ProductViewModel ProductViewModel { get; set; }

    public List<Product> newProducts1 = new List<Product>();


    private readonly IProductRepository productRepository;
    private readonly ICategoryRepository categoryRepository;

    public List<SelectListItem> Categories { get; set; }

    [BindProperty(SupportsGet = false)]
    public int CategoryId { get; set; }


    public AddNewProductModel(IProductRepository productRepository, ICategoryRepository categoryRepository)
    {
        //ctrl + .
        ProductViewModel = new();
        this.productRepository = productRepository;
        this.categoryRepository = categoryRepository;
    }

    public void OnGet()
    {
        Categories = new();

        Categories.AddRange(categoryRepository.GetAllCategories().Select(x => new SelectListItem()
        {
            Text = x.Title,
            Value = x.Id.ToString()
        }).ToList());

    }

    public IActionResult OnPost()
    {
        if (ModelState.IsValid == false)
        {
            return Page();
        }

        #region AppService

        var product = new Product();
        Helper.Map(ProductViewModel, product);
        product.CategoryId = CategoryId;

        productRepository.Add(product);

        #endregion

        return RedirectToPage("./Index");
    }

}
