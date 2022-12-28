using Microsoft.EntityFrameworkCore;
using NI_Library_Project.Shared.Models;

namespace NI_Library_Project.Server.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Rental>? Rentals { get; set; }
        public DbSet<Books>? Books { get; set; }
        public DbSet<Users>? Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\mssqllocaldb;Database=ServerDb;Integrated Security=True;");
        }
    }
}
