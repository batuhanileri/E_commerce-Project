using System.Collections.Generic;
using System.Linq;
using E_commerce.webui.Model;

namespace E_commerce.webui.Data
{
    public class CategoryRepository
    {
      private static List<category> _categories=null;

        static CategoryRepository()
        {
            _categories = new List<category>
            {
                new category {CategoryId=1, Name = "Pantalon",Description="pantalon kategorisi"},
                new category {CategoryId=1, Name = "Gömlek",Description="Gömlek kategorisi"},
                new category {CategoryId=1, Name = "Elbise",Description="Elbise kategorisi"}
            };
        }

        public static List<category> Categories
        {
            get
            {
                return _categories;
            }
        }

        public static void AddCategory(category category)
        {
            _categories.Add(category);
        }

        public static category GetCategorybyId(int id)
        {
            return _categories.FirstOrDefault(c=>c.CategoryId==id);
        }
  
    }
}