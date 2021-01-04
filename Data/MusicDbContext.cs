using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicApplication.Data.Entities;

namespace QuizyfyAPI.Data
{
    public class MusicDbContext : IdentityDbContext<User>
    {
        public MusicDbContext(DbContextOptions<MusicDbContext> options) : base(options)
        {
        }
        public DbSet<Performer> Performers { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<PerformerAlbum> PerformerAlbums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PerformerAlbum>()
                .HasKey(entity => new { entity.AlbumId, entity.PerformerId });
        }
    }
}