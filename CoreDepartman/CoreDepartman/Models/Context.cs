using Microsoft.EntityFrameworkCore;

namespace CoreDepartman.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-0KSRB41\\SQLEXPRESS;database=corepersonel;integrated security=true;");
        }

        public DbSet<departmanlar> departmanlars { get; set; }
        public DbSet<personel> personels { get; set; }
        public DbSet<Admin> admins { get; set; }
    }
}
