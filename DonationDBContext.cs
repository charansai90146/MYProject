using Microsoft.EntityFrameworkCore;

namespace MYPROJECT.Models
{
    public class DonationDBContext : DbContext
    {
        public DonationDBContext(DbContextOptions<DonationDBContext> options) : base(options)
        {
        }

        public DbSet<Dcondidates> Dcondidates { get; set; }
    }
}
