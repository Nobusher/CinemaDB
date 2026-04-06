using CinemaDB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDB
{
    internal class CinemaContext : DbContext
    {
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<CinemaView> CinemaViews { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=cinema;Username=postgres; Password=0000");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>(entity => 
            {
                entity.Property(t => t.CustomerName)
                .IsRequired()
                .HasMaxLength(100);

                entity.Property(t => t.PurchasedAt)
                .HasDefaultValueSql("NOW()");

                entity.HasOne(t => t.Session)
                .WithMany(s => s.Tickets)
                .HasForeignKey(t => t.SessionId)
                .OnDelete(DeleteBehavior.Cascade);
                entity.HasIndex(t => new { t.SessionId, t.SeatNumber })
                .IsUnique();
            });
        }
    }
}
