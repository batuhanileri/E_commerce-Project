using System.Collections.Generic;
using System.Linq;
using E_commerce.webui.Model;

namespace E_commerce.webui.Data
{
    public static class CategoryRepository
    {
      private static List<Category> _categories=null;

        static CategoryRepository()
        {
            _categories = new List<Category>
            {
                new Category {CategoryId=1, Name = "Pantalon",Description="pantalon kategorisi"},
                new Category {CategoryId=2, Name = "Gömlek",Description="Gömlek kategorisi"},
                new Category {CategoryId=3, Name = "Elbise",Description="Elbise kategorisi"}
            };
        }
        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }

        public static void AddCategory(Category category)
        {
            _categories.Add(category);
        }

        public static Category GetCategorybyId(int id)
        {
            return _categories.FirstOrDefault(c=>c.CategoryId==id);
        }
  
    }
}