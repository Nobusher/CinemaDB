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
        private readonly string _connectionString;

        public CinemaContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public CinemaContext(string username, string password, string connection)
        {
            _connectionString = $"Host={connection};Port=5432;Database=cinema;Username={username};Password={password}";
        }

        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<CinemaView> CinemaViews { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(_connectionString);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Director>()
                .HasIndex(d => d.Name)
                .IsUnique();
        }
    }
}
