using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ASPWebAPIDemoA.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }
        [Required]
        public String CustomerId { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public decimal Freight { get; set; }
        [Required]
        public String ShipCountry { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
        // IMPORTANT: Never use the following option . Will not work while inserting Parent - Child records
        //public List<OrderDetail> OrderDetails { get; } = new List<OrderDetails>();

    }
    [Table("Order Details")]
    public class OrderDetail {
        [Required]
        public int OrderId { get; set; }
        [Required]      
        public int ProductId { get; set; }
        [Required]
        public short Quantity { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public float  Discount { get; set; }

      
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
    }
}
