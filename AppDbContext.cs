using Microsoft.EntityFrameworkCore;
using QuanLySinhVien.DAL.Entities;

namespace QuanLySinhVien.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public AppDbContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=QuanLySinhVienDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}