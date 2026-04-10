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
        private string _connection;
        private string _password;

        public CinemaContext(string connection, string password)
        {
            _connection = connection;
            _password = password;
        }

        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<CinemaView> CinemaViews { get; set; }
        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql($"Host={_connection};Port=5432;Database=cinema;Username=postgres; Password={_password}");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Director>()
                .HasIndex(d => d.Name)
                .IsUnique();
        }
    }
}
