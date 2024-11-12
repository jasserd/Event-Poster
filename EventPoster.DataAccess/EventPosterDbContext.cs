using EventPoster.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventPoster.DataAccess
{
    public class EventPosterDbContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<AdministratorEntity> Administrators { get; set; }
        public DbSet<EventEntity> Events { get; set; }
        public DbSet<GenreEntity> Genres { get; set; }
        public DbSet<OfficeEntity> Offices { get; set; }
        public DbSet<TicketEntity> Tickets { get; set; }
        public DbSet<EventGenreEntity> EventsGenres { get; set; }

        public EventPosterDbContext(DbContextOptions<EventPosterDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().HasKey(u => u.Id);
            modelBuilder.Entity<UserEntity>().HasMany<TicketEntity>(u => u.Tickets)
                .WithOne(t => t.User);
            modelBuilder.Entity<AdministratorEntity>().HasBaseType<UserEntity>();
            modelBuilder.Entity<AdministratorEntity>().HasOne<OfficeEntity>(a => a.Office)
                .WithMany(o => o.Administrators);
            
            modelBuilder.Entity<EventEntity>().HasKey(e => e.Id);
            modelBuilder.Entity<EventEntity>().HasMany<TicketEntity>(e => e.Tickets)
                .WithOne(t => t.Event);
            modelBuilder.Entity<EventEntity>().HasMany<EventGenreEntity>(e => e.EventGenres)
                .WithOne(ge => ge.Event);
            
            modelBuilder.Entity<GenreEntity>().HasKey(g => g.Id);
            modelBuilder.Entity<GenreEntity>().HasMany<EventGenreEntity>(g => g.EventGenres)
                .WithOne(ge => ge.Genre);
        }
    }
}