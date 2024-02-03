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
    public CreateProductViewModel CreateProductViewModel { get; set; }

    public List<Product> newProducts1 = new List<Product>();

    public List<SelectListItem> Categories { get; set; }

    [BindProperty(SupportsGet = false)]
    public int CategoryId { get; set; }

    public void OnGet()
    {
        Categories = new();
        Categories.AddRange(Store.Categories.Select(x => new SelectListItem()
        {
            Text = x.Title,
            Value = x.Id.ToString()
        }).ToList());

    }
    public AddNewProductModel()
    {
        CreateProductViewModel = new();
    }


    public IActionResult OnPost()
    {
        if (ModelState.IsValid == false)
        {
            return Page();
        }

        var product = new Product();
        Helper.Map(CreateProductViewModel, product);
        product.Id = Store.Products.Count + 1;
        product.CategoryId = CategoryId;

        Store.Products.Add(product);
        return RedirectToPage("./Index");
    }

}
