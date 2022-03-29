using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo.Models
{
    public class EFCoreDemoContext : DbContext
    {
        // Constructeur => DbContextOptions en params implémente le constructeur de la classe mere DbContext
        public EFCoreDemoContext(DbContextOptions<EFCoreDemoContext> options) : base(options)
        {

        }
        // Proprièté DbSet => Permet la création des tables depuis les classes
        public DbSet<Student> Students { get; set; }      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\EntityBDD;Integrated Security=True");
        }
    }
}
