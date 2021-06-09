using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MyBackEnd.Models;
using MyBackEnd.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEnd.Controllers
{
    [Route("api/ticket")]
    public class TicketController : Controller
    {
        private TicketService ticketService;
        private IWebHostEnvironment webHostEnviroment;
        public TicketController(TicketService _ticketService, IWebHostEnvironment _webHostEnviroment)
        {
            ticketService = _ticketService;
            webHostEnviroment = _webHostEnviroment;
        }
        [HttpGet("findall")]
        [Produces("application/json")]
        public IActionResult FindAll()
        {
            try
            {
                return Ok(ticketService.FindAll());
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
                return Ok(ticketService.Search(min,max));
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("search-by-customerid/{customerId}")]
        [Produces("application/json")]
        public IActionResult SearchByCustomerId(int customerId)
        {
            try
            {
                return Ok(ticketService.SearchByCustomerId(customerId));
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("count-and-total-amount/{customerId}")]
        [Produces("application/json")]
        public IActionResult CountAndTotalAmount(int customerId)
        {
            try
            {
                return Ok(ticketService.CountAndTotalAmount(customerId));
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost("create")]
        [Produces("application/json")]
        public IActionResult Create([FromBody] CreateTicketRequest request)
        {
            try
            {
                return Ok(ticketService.Create(request));
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("searchbymonth/{year}/{month}")]
        [Produces("application/json")]
        public IActionResult SearchByMonth(string year, string month)
        {
            try
            {
                return Ok(ticketService.SearchByMonth(year, month));
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
