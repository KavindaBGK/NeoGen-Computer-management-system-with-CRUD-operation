using Microsoft.EntityFrameworkCore;

using NeoGen.Model;

namespace NeoGen.contextclass
{
    public class NeoGenComputerShopContext : DbContext
    {
        public NeoGenComputerShopContext(DbContextOptions<NeoGenComputerShopContext> options) : base(options) { }
        public DbSet<Seller> Sellers { get; set; }
    }

}
