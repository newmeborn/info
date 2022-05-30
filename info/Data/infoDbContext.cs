using Microsoft.EntityFrameworkCore;

namespace info.Models
{
    public class infoDbContext : DbContext
    {
        public infoDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<infomed> infomeds {get;set;}
    }
    
}
