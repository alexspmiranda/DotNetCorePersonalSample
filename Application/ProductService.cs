using System;
using System.Collections.Generic;
using Domain.Entity;
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

        public IEnumerable<Product> Get(){
            return _productRepository.Get();
        }
    }
}
