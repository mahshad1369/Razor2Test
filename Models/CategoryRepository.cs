

using System.Security.Cryptography.Xml;

namespace Razor2Test.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public CategoryRepository()
        {
        }

        public bool ExistCategory(int id)
        {
            return Store.Categories.Any(x => x.Id == id);
        }


        public Category Add(Category category)
        {
            category.Id = Store.Categories.Any() ? Store.Categories.Max(x => x.Id) + 1 : 1;
            Store.Categories.Add(category);
            return category;
        }

        public Category Delete(int id)
        {
            var category = Store.Categories.FirstOrDefault(x => x.Id == id);
            if (category is null)
            {
                return null;
            }
            Store.Categories.Remove(category);
            return category;
        }


        public Category? Get(int id)
        {
            return Store.Categories.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return Store.Categories;
        }


        public Category Update(Category categoryChanges)
        {
            var category = Store.Categories.FirstOrDefault(x => x.Id == categoryChanges.Id);
            if (category is not null)
            {
                Helper.Map(categoryChanges, category);
            }
            return category;
        }

    }
}
