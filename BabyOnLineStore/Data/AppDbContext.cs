using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BabyOnLineStore.Models;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http.Headers;

namespace BabyOnLineStore.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProductTypes> ProductTypes { get; set; }
        public DbSet<Product> Items { get; set; }
    }

}
