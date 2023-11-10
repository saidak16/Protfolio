using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class ProtfolioContext : DbContext
    {
        public ProtfolioContext(DbContextOptions<ProtfolioContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Ownier>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<ProtfolioItem>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Contact>().Property(x => x.Id).HasDefaultValueSql("NEWID()");

            modelBuilder.Entity<Ownier>().HasData(
                new Ownier()
                {
                    Id = Guid.NewGuid(),
                    Address = "Khartoum - sudan",
                    Avatar = "avatar.jpg",
                    FullName = "Ahmed Khaojaly Ahmed Ali",
                    Job = "Web Development - DotNet - API Intigration"
                });
        }

        public DbSet<Ownier> owniers { get; set; }
        public DbSet<ProtfolioItem> protfolioItems { get; set; }
        public DbSet<Contact> contacts { get; set; }
    }
}
