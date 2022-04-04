using ApiProverbsEntity.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProverbsEntity.Tools
{
    public class DataDbContext : DbContext
    {
        public DataDbContext()
        {
              
        }

        public DbSet<Proverb> Proverbs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ApiProverbs;Integrated Security=True");
        }
    }
}
