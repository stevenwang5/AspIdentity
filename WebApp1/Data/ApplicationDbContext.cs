using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp1.Core.Model;

namespace WebApp1.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
        public DbSet<Ninja>? Ninjas { get; set; }
        public DbSet<Plant>? Plants { get; set; }
        public DbSet<Pirate>? Pirates { get; set; }
        public DbSet<Zombie>? Zombies { get; set; }    
}
