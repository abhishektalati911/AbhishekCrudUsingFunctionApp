using AnishSqlWebApp.Models;

namespace AnishSqlWebApp.Services
{
    public interface IProductService
    {
        public  Task<IEnumerable<Product>> GetProducts();

    }
}