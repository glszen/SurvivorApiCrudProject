using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using SurvivorProject.Models;



namespace SurvivorProject.Data
{
    public class SurvivorContext : DbContext
    {

        public SurvivorContext(DbContextOptions<SurvivorContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Competitor> Competitors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Competitor>()
                .HasOne(P => P.Category) //Each competitor belongs to a category
                .WithMany(u => u.Competitors) //A category can have multiple competitor
                .HasForeignKey(p => p.CategoryId); //UserId determines which competitor the category belongs to
        }
    }
}
