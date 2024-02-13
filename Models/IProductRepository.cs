namespace Razor2Test.Models
{
    public interface IProductRepository
    {

        /// <summary>
        /// if exist return true
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool ExistProduct(int id);
        Product? Get(int id);
        IEnumerable<Product> GetAllProduct();
        IEnumerable<Product> GetProductsByCategoryId(int id);
        Product Add(Product product);
        Product Update(Product productChanges);
        Product? Delete(int id);
    }
}
