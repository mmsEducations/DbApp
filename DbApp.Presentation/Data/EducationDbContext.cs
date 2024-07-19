using DbApp.Presentation.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace DbApp.Presentation.Data
{
    public class EducationDbContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var constr = @"Server=.;Database=Education;Trusted_Connection=True;ConnectRetryCount=0;Encrypt=False";

            optionsBuilder.UseSqlServer(constr);
        }
    }
}
