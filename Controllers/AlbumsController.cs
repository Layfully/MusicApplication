using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicApplication.Data.Entities;
using QuizyfyAPI.Data;

namespace MusicApplication.Controllers
{
    public class AlbumsController : Controller
    {
        private readonly MusicDbContext _context;

        public AlbumsController(MusicDbContext context)
        {
            _context = context;
        }

        // GET: Albums
        public async Task<IActionResult> Index()
        {
            return View(await _context.Albums.ToListAsync());
        }

        // GET: Albums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var album = await _context.Albums
                .FirstOrDefaultAsync(m => m.Id == id);
            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }

        // GET: Albums/Create
        public IActionResult Create()
        {
            ViewBag.PublisherId = _context.Publishers.Select(publisher => new SelectListItem
            {
                Value = publisher.Id.ToString(),
                Text = publisher.Name
            }).ToList();
            
            ViewBag.PerformerList = _context.Performers.Select(performer => new SelectListItem
            {
                Value = performer.Id.ToString(),
                Text = performer.FullName
            }).ToList();
            
            return View();
        }

        // POST: Albums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,ReleaseDate,Genre,PublisherId,Picture")] Album album)
        {
            if (ModelState.IsValid)
            {
                _context.Add(album);

                if (Request.Form.Files.Count > 0)
                {
                    IFormFile file = Request.Form.Files.FirstOrDefault();
                    using var dataStream = new MemoryStream();
                    await file.CopyToAsync(dataStream);
                    album.Picture = dataStream.ToArray();
                }
                await _context.SaveChangesAsync();

                foreach (string id in Request.Form["Performers"])
                {
                    PerformerAlbum performerAlbum = new PerformerAlbum() { 
                        AlbumId = album.Id,
                        PerformerId = int.Parse(id)
                    };

                    _context.Add(performerAlbum);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(album);
        }

        // GET: Albums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var album = await _context.Albums.Include(album => album.PerformerAlbums).ThenInclude(performerAlbum => performerAlbum.Performer).FirstOrDefaultAsync(album => album.Id == id);

            if (album == null)
            {
                return NotFound();
            }


            ViewBag.PublisherId = _context.Publishers.Select(publisher => new SelectListItem
            {
                Value = publisher.Id.ToString(),
                Text = publisher.Name
            }).ToList();

            ViewBag.PerformerList = _context.Performers.Select(performer => new SelectListItem
            {
                Value = performer.Id.ToString(),
                Text = performer.FullName
            }).ToList();

            foreach(SelectListItem item in ViewBag.PerformerList)
            {
                item.Selected = album.PerformerAlbums.Any(albumPerformer => albumPerformer.PerformerId == int.Parse(item.Value));
            }

            return View(album);
        }

        // POST: Albums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ReleaseDate,Genre,PublisherId,Picture")] Album album)
        {
            if (id != album.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (Request.Form.Files.Count > 0)
                    {
                        IFormFile file = Request.Form.Files.FirstOrDefault();
                        using var dataStream = new MemoryStream();
                        await file.CopyToAsync(dataStream);
                        album.Picture = dataStream.ToArray();
                    }

                    album = await _context.Albums.Include(album => album.PerformerAlbums).AsNoTracking().FirstOrDefaultAsync(album => album.Id == id);

                    foreach (var performerAlbum in album.PerformerAlbums)
                    {
                        _context.PerformerAlbums.Remove(performerAlbum);
                    }


                    if (Request.Form.Files.Count > 0)
                    {
                        IFormFile file = Request.Form.Files.FirstOrDefault();
                        using var dataStream = new MemoryStream();
                        await file.CopyToAsync(dataStream);
                        album.Picture = dataStream.ToArray();
                    }

                    _context.Update(album);
                    await _context.SaveChangesAsync();

                    foreach (string performerId in Request.Form["Performers"])
                    {
                        PerformerAlbum performerAlbum = new PerformerAlbum()
                        {
                            AlbumId = album.Id,
                            PerformerId = int.Parse(performerId)
                        };

                        _context.Add(performerAlbum);
                    }
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlbumExists(album.Id))
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
            return View(album);
        }

        // GET: Albums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var album = await _context.Albums
                .FirstOrDefaultAsync(m => m.Id == id);
            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }

        // POST: Albums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var album = await _context.Albums.FindAsync(id);
            _context.Albums.Remove(album);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlbumExists(int id)
        {
            return _context.Albums.Any(e => e.Id == id);
        }
    }
}
