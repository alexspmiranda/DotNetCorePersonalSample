using System.Collections.Generic;
using Domain.Entity;

namespace Domain.Interfaces
{
    public interface IProductService
    {
         IEnumerable<Product> Get();
    }
}