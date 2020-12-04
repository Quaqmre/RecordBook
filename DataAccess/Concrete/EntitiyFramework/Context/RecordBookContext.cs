using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntitiyFramework.Context
{
    public class RecordBookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"server=localhost;port=3306;database=test;user=test_user;password=test");
        }
        public DbSet<User> Users { get; set; }
    }
}
