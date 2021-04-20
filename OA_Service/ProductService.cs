using OA_DataAccess;
using OA_Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA_Service
{
    public class ProductService : IProductService
    {
        private IRepository<Product> productRepository;
        private IRepository<ProductDetails> productDetailRepository;
        public ProductService(IRepository<Product> productRepository,   IRepository<ProductDetails> productDetailReposiory)
        {
            this.productRepository = productRepository;
            this.productDetailRepository = productDetailReposiory;
        }
        public IEnumerable<Product> GetProduct()
        {
            return productRepository.GetAll();
        }

        public Product GetProduct(int id)
        {
            return productRepository.Get(id);
        }
    }
}
