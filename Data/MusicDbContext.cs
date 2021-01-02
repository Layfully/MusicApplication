using Microsoft.EntityFrameworkCore;
using MusicApplication.Data.Entities;

namespace QuizyfyAPI.Data
{
    public class MusicDbContext : DbContext
    {
        public MusicDbContext(DbContextOptions<MusicDbContext> options) : base(options)
        {
        }
        public DbSet<Performer> Performers { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}