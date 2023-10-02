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

        public DbSet<Ownier> owniers { get; set; }
        public DbSet<ProtfolioItem> protfolioItems { get; set; }
        public DbSet<Contact> contacts { get; set; }
    }
}
