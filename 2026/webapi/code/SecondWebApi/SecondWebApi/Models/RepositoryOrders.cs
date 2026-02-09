using Microsoft.EntityFrameworkCore;

namespace SecondWebApi.Models
{
    public class RepositoryOrders
    {
        private NorthwindContext _context;
        public RepositoryOrders(NorthwindContext context)
        {
            _context = context;
        }
        public List<int> GetAllOrderId()
        {
            var orderids= (from o in _context.Orders.Include(d=>d.OrderDetails)
                          select o.OrderId).ToList();
            return orderids;
        }
        public Order FindOrderById(int id)
        {
            var orderById = _context.Orders.Find(id);
            return orderById;
        }
        public List<Order> FindOrderByCustomerID(string customerID)
        {
            List<Order> orderList = new List<Order>();
             foreach(var item in _context.Orders)
            {
                if(item.CustomerId == customerID)
                {
                    orderList.Add(item);
                }
            }             
            List<Order> customerOrders=(from o in _context.Orders
                                       where o.CustomerId == customerID
                                       select o).ToList();
            return customerOrders;
        }
        // Without Include
        public List<OrderDetail> FindOrderDetailByOrderId(int id) {

            //Order order = _context.Orders.Find(id);
            #region include
            List<Order> ordersWithOrderDetails = 
                _context.Orders.Include(d => d.OrderDetails).ToList();
            Order order = 
                ordersWithOrderDetails.FirstOrDefault(x => x.OrderId == id);
            #endregion
            return order.OrderDetails.ToList();
        }
        public List<OrderDetail> FindOrderDetailByOrderIdWithInclude(int id)
        {
            List<Order> ordersWithOrderDetails = _context.Orders.Include(d => d.OrderDetails).ToList();
            Order order = ordersWithOrderDetails.FirstOrDefault(x => x.OrderId == id); //FindOrderById(id);
            return order.OrderDetails.ToList();
        }
        public Product GetProductById(int productid)
        {
            var product = _context.Products.Find(productid);
            return product;
        }
    }
}
