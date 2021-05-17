using E_commerce.dataa.Abstract;

namespace E_commerce.dataa.Concrete.EfCore
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShopContext _context;
        public UnitOfWork(ShopContext context)
        {
                   _context=context;
        }

        private EfCoreCartRepository _cartRepository;
        private EfCoreCategoryRepository _categoryRepository;
        private EfCoreOrderRepository _orderRepository;
        private EfCoreProductRepository _productRepository;
        public ICartRepository Carts => 
        _cartRepository ?? new EfCoreCartRepository(_context);
        public IProductRepository Products => 
        _productRepository ?? new EfCoreProductRepository(_context);

        public IOrderRepository Orders => 
        _orderRepository ?? new EfCoreOrderRepository(_context);

        public ICategoryRepository Categories => 
        _categoryRepository ?? new EfCoreCategoryRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}