using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicApplication.Models;
using QuizyfyAPI.Data;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MusicApplication.Controllers
{

    [Authorize]
    public class HomeController : Controller
    {
        private readonly MusicDbContext _context;


        public HomeController(MusicDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var x = await _context.Songs.Include(song => song.Album).ThenInclude(album => album.PerformerAlbums).ThenInclude(performerAlbum => performerAlbum.Performer).ToListAsync();
            return View(x);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
