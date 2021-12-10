using System;
using festivalsql.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace festivalsql.Server.Data
{
    public class ShiftContext : DbContext
    {
        public virtual DbSet<Shift> vagt { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(@"Server = 127.0.0.1; Port = 5432; Database = festival; User Id=postgres; Password=barackobama; CommandTimeout = 20");
                //optionsBuilder.UseNpgsql(@"Server=miljoefest.postgres.database.azure.com;Database=festival;Port=5432;User Id=victorp;Password=zajpIb-meqtom-gerwi5;Ssl Mode=Require;");
            }
        }
    }
}
