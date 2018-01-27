using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using MusicStore.Models;
using Microsoft.EntityFrameworkCore;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
      public MusicStoreEntities storeDB { get; set; }

        public StoreController(MusicStoreEntities storeDB)
        {
            this.storeDB = storeDB;
        }

        public ActionResult Index()
        {

            var genres = storeDB.Genres.Include(g => g.Albums);
            return View(genres);
        }

        /* public ActionResult Index()
        {
            var genres = new List<Genre>
    {
        new Genre { Name = "Disco"},
        new Genre { Name = "Jazz"},
        new Genre { Name = "Rock"}
    };
            return View(genres);
        }
        /*  public IActionResult Index()
          {
              return View();
          }*/
        /*public string Index()
        {
            return "Hello from Store.Index()";
        }*/
        //
        // GET: /Store/Browse
        public ActionResult Browse(string genre)
        {
            var genreModel = storeDB.Genres.Include("Albums")
        .Single(g => g.Name == genre);

            return View(genreModel);
        }
        /* public string Browse(string genre)
         {
             string message = HttpUtility.HtmlEncode("Store.Browse, Genre = "
         + genre);

             return message;
         }*/
        //
        // GET: /Store/Details
        /* public string Details()
         {
             return "Hello from Store.Details()";
         }*/
        //
        // GET: /Store/Details/5
        public IActionResult Details(int id)
        {
            /*  string message = "Store.Details, ID = " + id;

              return message;*/
            var album = new Album { Title = "Album " + id };
            return View(album);
        }

    }
}