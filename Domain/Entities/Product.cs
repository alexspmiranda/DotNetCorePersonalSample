namespace Domain.Entity
{
    public class Product
    {
        public int IdProduct{get; set;}
        public string ProductName { get; set;}

        public int IdProductClass { get; set; }
        
//        public virtual int ProductClass{ get; }
    }
}