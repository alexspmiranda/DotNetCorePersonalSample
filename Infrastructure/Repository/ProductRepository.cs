using System.Collections.Generic;
using Domain.Entity;
using Domain.Interfaces;

namespace Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseContext _context;
        public ProductRepository(DatabaseContext context){
            _context = context;
        }

        public IEnumerable<Product> Get(){
            return _context.Product;
        }
    }
}