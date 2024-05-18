using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DatabaseContext:DbContext
    {
    public DatabaseContext(DbContextOptions options):base(options)
            {
   
            }
            public DbSet<RegisterModel> Register { get; set; }
        public DbSet<LoginModel> Login { get; set; }

    }
    }
