using ApiRestFullCrudEtudiantEntity.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiRestFullCrudEtudiantEntity.Tools
{
    public class DataDbContext : DbContext
    {
        public DataDbContext()
        {
              
        }

        public DbSet<Student> Students { get; set; }
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\EntityBDD;Integrated Security=True");
        }
    }
}
