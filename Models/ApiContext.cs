using Microsoft.EntityFrameworkCore;
using SmartHome.API.Entities;

namespace SmartHome.API.Models
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }

        public DbSet<Server> Servers {get; set;}
        public DbSet<User> User {get; set;}
    }
}