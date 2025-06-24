using Microsoft.EntityFrameworkCore;

namespace Chat_App_API.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        }
        public DbSet<UsersTable> Users { get; set; }


    } 
   
}
    
