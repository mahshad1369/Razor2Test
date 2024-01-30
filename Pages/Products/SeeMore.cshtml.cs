using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor2Test.Models;
using System.Xml.Linq;

namespace Razor2Test.Pages.Products
{
    public class SeeMoreModel : PageModel
    {
        public List<Comment> Comments { get; set; }
        public List<Question> Questions { get; set; }

        [BindProperty(SupportsGet = false)]
        public Product newProduct { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public Comment comment { get; set; }

        [BindProperty]
        public Question question { get; set; }

        public SeeMoreModel()
        {

            Comments = new List<Comment>();
            Questions = new List<Question>();
        }

        public IActionResult OnGet(int id)
        {
            var product = Store.Products.FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                return NotFound();
            }
            else
            {
                newProduct = product;
                return Page();
            }
        }

        public IActionResult OnPost()
        {

            var product = Store.Products.FirstOrDefault(x => x.Id == Id);
           
                newProduct = product;
                Comments = new List<Comment>();
                Questions = new List<Question>();
                //if (ModelState.IsValid)
                // {
                var comment=new Comment()
                {
                    Text = Request.Form["commentText"],
                    ProductId=Id
                };
            
                Comments.Add(comment);
                comment.ProductId = Id;
            return Page();
                //return RedirectToPage("./SeeMore", new { id = newProduct.Id });
            //}
        }
    }
}
