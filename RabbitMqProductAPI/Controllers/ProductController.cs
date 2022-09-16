using Microsoft.AspNetCore.Mvc;
using RabbitMqProductAPI.Models;
using RabbitMqProductAPI.RabitMQ;
using RabbitMqProductAPI.Services;
namespace RabitMqProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductservice Productservice;
        private readonly IRabitMQProducer _rabitMQProducer;
        public ProductController(IProductservice _Productservice, IRabitMQProducer rabitMQProducer)
        {
            Productservice = _Productservice;
            _rabitMQProducer = rabitMQProducer;
        }
        [HttpGet("productlist")]
        public IEnumerable<Product> ProductList()
        {
            var productList = Productservice.GetProductList();
            return productList;
        }
        [HttpGet("getproductbyid")]
        public Product GetProductById(int Id)
        {
            return Productservice.GetProductById(Id);
        }
        [HttpPost("addproduct")]
        public Product AddProduct(Product product)
        {
            var productData = Productservice.AddProduct(product);
            //send the inserted product data to the queue and consumer will listening this data from queue
            _rabitMQProducer.SendProductMessage(productData);
            return productData;
        }
        [HttpPut("updateproduct")]
        public Product UpdateProduct(Product product)
        {
            return Productservice.UpdateProduct(product);
        }
        [HttpDelete("deleteproduct")]
        public bool DeleteProduct(int Id)
        {
            return Productservice.DeleteProduct(Id);
        }
    }
}