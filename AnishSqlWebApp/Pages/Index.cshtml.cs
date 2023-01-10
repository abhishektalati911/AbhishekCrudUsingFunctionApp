using AnishSqlWebApp.Models;
using AnishSqlWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AnishSqlWebApp.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Product> Products;
        private readonly ProductService _productService;

        public IndexModel(ProductService productService)
        {
            _productService = productService;
        }
        public async void OnGet()
        {

            
            Products = _productService.GetProducts().GetAwaiter().GetResult();
           

        }
    }
}