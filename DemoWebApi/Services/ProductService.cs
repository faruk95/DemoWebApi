using DemoWebApi.Interface;

namespace DemoWebApi.Services
{
    public class ProductService : IProductService
    {
       

        public string GetName(string name)
        {
            return name;
        }
    }
}
