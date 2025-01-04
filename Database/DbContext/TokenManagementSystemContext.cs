using database.Model;
using Microsoft.EntityFrameworkCore;

namespace Database.Context
{
    public class TokenManagementSystemContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=TMS;Trusted_Connection=True;TrustServerCertificate=True;ConnectRetryCount=0");
        }
        public DbSet<UserInfo> ?UserInfo { get; set; }
        public DbSet<Role> ?Role { get; set; }

    }
}
