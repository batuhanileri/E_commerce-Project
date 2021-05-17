using E_commerce.business.Abstract;
using E_commerce.entity;
using E_commerce.dataa.Concrete.EfCore;
using E_commerce.dataa.Abstract;
using System.Collections.Generic;

namespace E_commerce.business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IUnitOfWork _unitofwork;
        public ProductManager(IUnitOfWork unitofwork)
        {
            _unitofwork=unitofwork;
        }
        public void Create(Product entity)
        {
            _unitofwork.Products.Create(entity);
            _unitofwork.Save();
        }

        public void Delete(Product entity)
        {
             _unitofwork.Products.Delete(entity);
            _unitofwork.Save();

        }

        public List<Product> GetAll()
        {
            return  _unitofwork.Products.GetAll();
        }

        public Product GetById(int id)
        {
            return  _unitofwork.Products.GetById(id);
        }

        public Product GetByIdWithCategories(int id)
        {
            return  _unitofwork.Products.GetByIdWithCategories(id);
        }

        public int GetCountByCategory(string category)
        {
            return  _unitofwork.Products.GetCountByCategory(category);
        }

        public List<Product> GetHomePageProducts()
        {
            return  _unitofwork.Products.GetHomePagesProducts();
        }

        public List<Product> GetProductByCategory(string name,int page,int pageSize)
        {
            return  _unitofwork.Products.GetProductByCategory(name,page,pageSize);
        }

        public Product GetProductDetails(string url)
        {
            return  _unitofwork.Products.GetProductDetails(url);
        }

        public List<Product> GetSearchResult(string searchString)
        {
            return  _unitofwork.Products.GetSearchResult(searchString);
        }

        public void Update(Product entity)
        {
             _unitofwork.Products.Update(entity);
            _unitofwork.Save();

        }

        public void Update(Product entity, int[] categoryIds)
        {
             _unitofwork.Products.Update(entity,categoryIds);
            _unitofwork.Save();

        }
    }
}