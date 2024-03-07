using InstaWeb.Infrastructure.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaWeb.Infrastructure.DAL
{
    class InstaWebDbContext : DbContext
    {
        public InstaWebDbContext(DbContextOptions<InstaWebDbContext> options) : base(options)
        {
        }

        public DbSet<DriverEntity> Drivers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DriverEntity>().ToTable("Drivers");
        }

    }
}
