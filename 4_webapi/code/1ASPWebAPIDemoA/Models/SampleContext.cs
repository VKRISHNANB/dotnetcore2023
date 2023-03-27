
using Microsoft.EntityFrameworkCore;
namespace ASPWebAPIDemoA.Models
{
    public class SampleContext : DbContext
    {
        public SampleContext(DbContextOptions<SampleContext> options) : base(options) { }
     
        public virtual DbSet<Customer> Customer { get; set; }

    }

    public class NwindContext : DbContext
    {
        public NwindContext(DbContextOptions<NwindContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>()
                .HasKey(c => new { c.OrderId, c.ProductId });
            modelBuilder.Entity<Order>(entity => {
                entity.HasKey(c =>  c.OrderId);
                entity.HasMany(d => d.OrderDetails)
                .WithOne(b=>b.Order);
            });
           
        }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
    }
    
}