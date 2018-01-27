using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public static class PopulateDatabase
    {

        //private static Labo6Context _context;

        //public PopulateDatabase(Labo6Context context)
        //{
        //    _context = context;
        //}

        public static void EnsurePopulated(MusicStoreEntities context)
        {
            context.Database.EnsureCreated();
            //Labo6Context context = app.ApplicationServices
            //    .GetRequiredService<Labo6Context>();
            //if (!context.Genres.Any())
            
                Genre g1 = new Genre { Name = "Rock", Description = "rock n roll" };
                Genre g2 = new Genre { Name = "Jazz", Description = "jazzy music" };
                Genre g3= new Genre { Name = "disco", Description = "disco music" };
                Genre g4 = new Genre { Name = "Métal", Description = "Métal music" };
                 Genre g5 = new Genre { Name = "dance", Description = "danse music" };
                Genre g6 = new Genre { Name = "Latin", Description = "salsa music" };
                Genre g7 = new Genre { Name = "Blue", Description = "Blue music" };
                Genre g8 = new Genre { Name = "India Music", Description = "india music" };
                context.Genres.Add(g1);
               context.Genres.Add(g2);
                context.Genres.Add(g3);
            Artist As1 = new Artist { Name = "dire street" };
                Artist As2 = new Artist { Name = "Celine dione" };
                Artist As3 = new Artist { Name = "David guetta" };
                context.Artises.Add(As1);
                context.Artises.Add(As2);
                context.Artises.Add(As3);
            Album a1 = new Album { Title = "AMOUR INVISIBLE", Price = 10, Genre = g1, Artist=As1, AlbumArtUrl = "www.music.fr" };
             Album a2 = new Album { Title = "GIVE ME YOUR HEART", Price = 10, Genre = g2, Artist = As2,AlbumArtUrl = "www.music.fr" };
             Album a3 = new Album { Title = "I need you", Price = 10, Genre = g3, Artist = As3, AlbumArtUrl = "www.music.fr" };
                
                context.Albums.Add(a1); context.Albums.Add(a2); context.Albums.Add(a3);

            context.SaveChanges();
            
        }
    }
}

