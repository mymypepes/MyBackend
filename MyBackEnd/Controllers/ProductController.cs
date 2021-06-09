using Microsoft.AspNetCore.Mvc;
using MyBackEnd.Models;
using MyBackEnd.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEnd.Controllers
{
    [Route("api/product")]
    public class ProductController : Controller
    {
        private ProductServices productServices;

        public ProductController(ProductServices _productServices)
        {
            productServices = _productServices;
        }

        [HttpGet("find")]
        [Produces("application/json")]
        public IActionResult Find()
        {
            try
            {
                return Ok(productServices.Find());
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("findall")]
        [Produces("application/json")]
        public IActionResult FindAll()
        {
            try
            {
                return Ok(productServices.FindAll());
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("search/{min}/{max}")]
        [Produces("application/json")]
        public IActionResult Search(double min, double max)
        {
            try
            {
                return Ok(productServices.Search(min, max));
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost("create")]
        [Consumes("application/json")]
        public IActionResult Create([FromBody] Product product)
        {
            try
            {
                
                return Ok(productServices.Create(product));
            }
            catch
            {
                return BadRequest();
            }
        }


        [HttpPut("update")]
        [Consumes("application/json")]
        public IActionResult Update([FromBody] Product product)
        {
            try
            {

                return Ok(productServices.Update(product));
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                productServices.Delete(id);
                return Ok(new
                {
                    result = true
                });
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] Login request)
        {
            try
            {   
                return Ok(productServices.Login(request));
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
