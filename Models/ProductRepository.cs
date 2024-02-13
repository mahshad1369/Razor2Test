
namespace Razor2Test.Models;

public class ProductRepository : IProductRepository
{
    //private List<Product> _productsList;
    public ProductRepository()
    {
        //_productsList = Store.Products;
    }

    public Product Add(Product product)
    {
        if (Store.Products.Any())
        {
            product.Id = Store.Products.Max(x => x.Id) + 1;
        }
        else
            product.Id = 1;
        Store.Products.Add(product);
        return product;

    }
    public Product? Get(int id)
    {
        return Store.Products.FirstOrDefault(x => x.Id == id);
    }

    public IEnumerable<Product> GetProductsByCategoryId(int id)
    {
        return Store.Products.Where(x => x.CategoryId == id);
    }


    public Product? Delete(int id)
    {
        // یادت بمونه مستشار
        //var product = Store.Products.FirstOrDefault(x => x.Id == id) ?? throw new Exception("محصول یافت نشد.");
        var product = Store.Products.FirstOrDefault(x => x.Id == id);
        if (product is null)
        {
            return null;
        }
        Store.Products.Remove(product);
        return product;
    }

    public bool ExistProduct(int id)
    {
        return Store.Products.Any(x => x.Id == id);
    }

    public IEnumerable<Product> GetAllProduct()
    {
        return Store.Products;
    }



    public Product Update(Product productChanges)
    {
        var product = Store.Products.FirstOrDefault(x => x.Id == productChanges.Id);
        if (product is not null)
        {
            Helper.Map(productChanges, product);

        }
        return product;
    }
}
