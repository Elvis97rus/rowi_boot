using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Bootcamp
{
    public class AscentContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Mountain> Mountains { get; set; }
        public DbSet<Ascent> Ascents { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Climber> Climbers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=ascents;User Id=SA;");
        }
        //@"Data Source=artemsh-msi\SQLEXPRESS;Initial Catalog=ascents;Integrated Security=True"
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ascent>().HasOne(x => x.Mountain).WithMany(x => x.Ascents).HasForeignKey(x => x.MountainId).IsRequired(true);
        }
    }
}
