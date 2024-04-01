using DemoWebApplication.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace DemoWebApplication.API.Data
{
    public class DemoWalksDbContextcs : DbContext
    {
        public DemoWalksDbContextcs(DbContextOptions dbContextOptions) : base(dbContextOptions) 
        {
            
        }

        public DbSet<Difficuilty> Difficuilties { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }
    }
}
