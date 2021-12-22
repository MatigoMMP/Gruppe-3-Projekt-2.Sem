using Microsoft.EntityFrameworkCore;

namespace festivalsql.Shared.Models
{
    public class FestivalContext : DbContext
    {
        public virtual DbSet<Job> opgave { get; set; }

        public virtual DbSet<Shift> vagt { get; set; }

        public virtual DbSet<User> bruger { get; set; }

        public virtual DbSet<JobDetail> opgavedetalje { get; set; }

        public virtual DbSet<Place> placering { get; set; }

        public virtual DbSet<Status> status { get; set; }

        public virtual DbSet<Partout> partout { get; set; }

        public virtual DbSet<OneDay> endags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // connection string lokalt
                //optionsBuilder.UseNpgsql(@"Server = 127.0.0.1; Port = 5432; Database = Testdb; User Id=postgres; Password=1234; CommandTimeout = 20");

                // connection string på cloud
                optionsBuilder.UseNpgsql(@"Server=gruppe3festival.postgres.database.azure.com;Database=festival;Port=5432;User Id=gruppe3;Password=jesperSEJ123;Ssl Mode=Require;");
            }
        }
    }
}