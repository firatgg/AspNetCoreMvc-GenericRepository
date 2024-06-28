using AspNetCoreMvc_GenericRepository.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace AspNetCoreMvc_GenericRepository.Data
{
    public class UrunDbContext : DbContext
    {
        public UrunDbContext(DbContextOptions<UrunDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
