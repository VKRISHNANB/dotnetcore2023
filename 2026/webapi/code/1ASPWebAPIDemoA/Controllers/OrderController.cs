using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPWebAPIDemoA.Models;
using ASPWebAPIDemoA.Services;
using Microsoft.AspNetCore.Cors;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPWebAPIDemoA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]

    public class OrderController : ControllerBase
    {
        private OrderService _Service { get; set; }
        public OrderController(OrderService service) { _Service = service; }
        // GET: api/<OrderController>
        [HttpGet]
        public List<Order> Get()
        {
            return _Service.GetAllOrders();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return _Service.GetOrderById(id);
        }
        // GET api/<OrderController>/5
        //[HttpGet("{id}")]
        //public List<OrderDetail> FindOrderDetails(int id)
        //{
        //    return _Service.GetAllOrderDetailsByOrderId(id);
        //}
        // POST api/<OrderController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
