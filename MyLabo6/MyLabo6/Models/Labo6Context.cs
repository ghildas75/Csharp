using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GGPCSNETLabo6.Models
{
    public class Labo6Context : DbContext
    {
        public Labo6Context(DbContextOptions<Labo6Context> options)
            : base(options)
        { }

        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Client");

        }

    }
}
