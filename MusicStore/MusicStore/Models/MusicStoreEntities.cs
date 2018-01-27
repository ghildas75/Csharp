using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class MusicStoreEntities:DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artises { get; set; }
        public MusicStoreEntities(DbContextOptions options):base(options)
         {
         }

      /*  protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(confi);
        }*/
    }
}
