using System.Collections.Generic;
using Domain.Entity;

namespace Domain.Interfaces
{
    public interface IProductRepository
    {
         IEnumerable<Product> Get();
    }
}