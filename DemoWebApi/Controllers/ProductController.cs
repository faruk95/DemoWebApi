using DemoWebApi.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
             _productService = productService;
        }
        [HttpGet]
        public string GetName(string name)
        {
            return _productService.GetName(name);
        }
    }
}
