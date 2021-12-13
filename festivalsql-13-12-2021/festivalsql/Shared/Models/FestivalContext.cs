﻿using System;
using festivalsql.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace festivalsql.Shared.Models
{
    public class FestivalContext : DbContext
    {
        public virtual DbSet<Job> opgave { get; set; }

        public virtual DbSet<Shift> vagt { get; set; }

        public virtual DbSet<User> bruger { get; set; }

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
