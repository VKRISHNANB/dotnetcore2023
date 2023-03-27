
using Microsoft.EntityFrameworkCore;
namespace Aspnetmvcapp
{
    public class SampleContext : DbContext
    {
        public SampleContext(DbContextOptions<SampleContext> options) : base(options) { }
        public virtual DbSet<Customer> Customer { get; set; }
    }
}