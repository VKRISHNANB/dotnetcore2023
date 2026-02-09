using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPWebAPIDemoA.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPWebAPIDemoA.Services
{
    public class OrderService
    {
        private NwindContext _NwindContext { get; set; }
        public OrderService(NwindContext context) { _NwindContext = context; }
        public List<Order> GetAllOrders()
        {
            return _NwindContext.Orders.ToList();
        }
        public Order GetOrderById(int id)
        {
            Order order = _NwindContext.Orders.Single(o => o.OrderId == id);

            _NwindContext.Entry(order).Collection(b => b.OrderDetails).Load();
            //List<Order> orders = _NwindContext.Orders.Include(details => details.OrderDetails).ToList();
            //Order order = orders.Single(x=>x.OrderId==id);
            return order;
        }
        public List<OrderDetail> GetAllOrderDetailsByOrderId(int orderId)
        {
            var details = (from orddetails in _NwindContext.OrderDetails
                           where orddetails.OrderId == orderId
                           select orddetails).ToList();
            return details;
        }
    }
}
