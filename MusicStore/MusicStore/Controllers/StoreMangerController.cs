using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class StoreMangerController : Controller
    {
        private readonly MusicStoreEntities _context;
   
        public StoreMangerController(MusicStoreEntities context)
        {
            _context = context;
        }

        // GET: StoreManger
        [Route("StoreManager")]
        //
        // GET: /StoreManager/
        public ViewResult Index()
        {
            var albums = _context.Albums.Include(a => a.Genre).Include(a => a.Artist);
            return View(albums.ToList());
        }
        /*public async Task<IActionResult> Index()
        {
            var musicStoreEntities = _context.Albums.Include(a => a.Artist).Include(a => a.Genre);
            return View(await musicStoreEntities.ToListAsync());
        }*/

        // GET: StoreManger/Details/5
        //
        // GET: /StoreManager/Details/5
        public ViewResult Details(int id)
        {
            Album album = _context.Albums.Find(id);
            return View(album);
        }
        /*public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var album = await _context.Albums
                .Include(a => a.Artist)
                .Include(a => a.Genre)
                .SingleOrDefaultAsync(m => m.AlbumId == id);
            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }*/

        // GET: StoreManger/Create
        public IActionResult Create()
        {
            ViewData["ArtistId"] = new SelectList(_context.Artises, "ArtistId", "ArtistId");
            ViewData["GenreId"] = new SelectList(_context.Genres, "GenreId", "GenreId");
            return View();
        }

        // POST: StoreManger/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        
        [ValidateAntiForgeryToken]
        //
        // POST: /StoreManager/Create
        [HttpPost]
        public ActionResult Create(Album album)
        {
            if (ModelState.IsValid)
            {
                _context.Albums.Add(album);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GenreId = new SelectList(_context.Genres, "GenreId", "Name", album.GenreId);
            ViewBag.ArtistId = new SelectList(_context.Artises, "ArtistId", "Name", album.ArtistId);
            _context.Albums.Add(album);
            _context.SaveChanges();
            return View(album);
        }

        public ActionResult Edit(int id)
        {
            Album album = _context.Albums.Find(id);
            ViewBag.GenreId = new SelectList(_context.Genres, "GenreId", "Name", album.GenreId);
            ViewBag.ArtistId = new SelectList(_context.Artises, "ArtistId", "Name", album.ArtistId);
            return View(album);
        }
        /* public async Task<IActionResult> Create([Bind("AlbumId,GenreId,ArtistId,Title,Price,AlbumArtUrl")] Album album)
         {
             if (ModelState.IsValid)
             {
                 _context.Add(album);
                 await _context.SaveChangesAsync();
                 return RedirectToAction(nameof(Index));
             }
             ViewData["ArtistId"] = new SelectList(_context.Artises, "ArtistId", "ArtistId", album.ArtistId);
             ViewData["GenreId"] = new SelectList(_context.Genres, "GenreId", "GenreId", album.GenreId);
             return View(album);
         }*/

        // GET: StoreManger/Edit/5
        //
        // POST: /StoreManager/Edit/5
        [HttpPost]
        public ActionResult Edit(Album album)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(album).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GenreId = new SelectList(_context.Genres, "GenreId", "Name", album.GenreId);
            ViewBag.ArtistId = new SelectList(_context.Artises, "ArtistId", "Name", album.ArtistId);
            return View(album);
        }
        /* public async Task<IActionResult> Edit(int? id)
         {
             if (id == null)
             {
                 return NotFound();
             }

             var album = await _context.Albums.SingleOrDefaultAsync(m => m.AlbumId == id);
             if (album == null)
             {
                 return NotFound();
             }
             ViewData["ArtistId"] = new SelectList(_context.Artises, "ArtistId", "ArtistId", album.ArtistId);
             ViewData["GenreId"] = new SelectList(_context.Genres, "GenreId", "GenreId", album.GenreId);

             return View(album);
         }*/

        // POST: StoreManger/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
       /* [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AlbumId,GenreId,ArtistId,Title,Price,AlbumArtUrl")] Album album)
        {
            if (id != album.AlbumId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(album);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlbumExists(album.AlbumId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArtistId"] = new SelectList(_context.Artises, "ArtistId", "ArtistId", album.ArtistId);
            ViewData["GenreId"] = new SelectList(_context.Genres, "GenreId", "GenreId", album.GenreId);
            return View(album);
        }*/

        //
        // GET: /StoreManager/Delete/5

        public ActionResult Delete(int id)
        {
            Album album = _context.Albums.Find(id);
            return View(album);
        }
        //
        // POST: /StoreManager/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Album album = _context.Albums.Find(id);
            _context.Albums.Remove(album);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        // GET: StoreManger/Delete/5
        /*public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var album = await _context.Albums
                .Include(a => a.Artist)
                .Include(a => a.Genre)
                .SingleOrDefaultAsync(m => m.AlbumId == id);
            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }*/

        // POST: StoreManger/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
       /* public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var album = await _context.Albums.SingleOrDefaultAsync(m => m.AlbumId == id);
            _context.Albums.Remove(album);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }*/

        private bool AlbumExists(int id)
        {
            return _context.Albums.Any(e => e.AlbumId == id);
        }
    }
}
