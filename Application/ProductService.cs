using System;
using Domain.Interfaces;

namespace Application
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _productRepository;
        
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public int Get(){
            return _productRepository.Get();
        }
    }
}
