namespace Razor2Test.Models
{
    public interface ICategoryRepository
    {
        bool ExistCategory(int id);
        Category? Get(int id);
        IEnumerable<Category> GetAllCategories();
        Category Add(Category category);
        Category Update(Category categoryChanges);
        Category Delete(int id);

    }
}
