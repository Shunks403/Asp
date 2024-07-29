using ShopProjectMVC.Core.Interfaces;
using ShopProjectMVC.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProjectMVC.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository _repository;
        public ProductService(IRepository repository) 
        {
        
            _repository = repository;
        }

        public Task<Product> AddProduct(Product product)
        {
            return _repository.Add(product);
        }

        public async Task<Order> BuyProduct(int userId, int productId)
        {
            var product =  await _repository.GetById<Product>(productId);
            var user = await _repository.GetById<User>(userId);
            Order order = new Order();

            order.Product = product;
            order.User = user;
            order.CreatedAt = DateTime.Now;

            return await _repository.Add(order);

        }

        public Task DeleteProduct(int id)
        {
            return _repository.Delete<Product>(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _repository.GetAll<Product>().ToList();
        }

        public Task<Product> GetProductById(int id)
        {
            return _repository.GetById<Product>(id);
        }

        public Task<Product> UpdateProduct(Product product)
        {
            return _repository.Update(product);
        }
    }
}
