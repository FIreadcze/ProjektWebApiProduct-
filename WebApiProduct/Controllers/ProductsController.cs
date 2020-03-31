using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiProduct.Models;
using WebApiProduct.Repository;

namespace WebApiProduct.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly ProductsRepository _repository;
        public ProductsController(ProductsRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Products
        [HttpGet]
        //data models Product
        public IEnumerable<Product> Get()
        {
            return _repository.GetProducts();
        }
        // GET: api/Products/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(int id) {
            if (!_repository.TryGetProduct(id, out var product)) {
                return NotFound();
            }
            return Ok(product);
        }
        
        // POST: api/Products
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task <IActionResult>CreateAsync([FromBody] Product product)
        {
            if (product.Description.Contains("XYZ Widget")){
                return BadRequest();
            }
            await _repository.AddProductAsync(product);
            return CreatedAtAction(nameof(GetById),new { id=product.Id},product);
        }

       

    }
}
