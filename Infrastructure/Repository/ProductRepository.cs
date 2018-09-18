using Domain.Interfaces;

namespace Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        public int Get(){
            return 1;
        }
    }
}