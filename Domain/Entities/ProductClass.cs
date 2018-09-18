using System.Collections.Generic;

namespace Domain.Entity
{
    public class ProductClass
    {
        public int IdProductClass { get;  }
        
        public string ProductClassName { get;  }

        public IEnumerable<Product> Product {get;} 
    }
}