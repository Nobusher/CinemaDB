using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDB.Models
{
    internal class Director
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public List<Film> Films { get; set;}
    }
    internal class Genre 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Film> Films { get; set;}
    }
    internal class Film 
    {
        public int Id { get; set; }
        public string Title { get;set;}
        public int Year { get; set;}
        public int Duration { get; set; }
        public int DirectorId { get; set; }
        public Director Director { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public List<Session> Sessions { get; set;}
        public bool IsVisible { get; set; } = true;//NEW

    }
    
    internal class Session 
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Price { get; set; }
        public int FilmID { get; set; }
        public Film Film { get; set; }
        public int HallId { get; set; }
        public Hall Hall { get; set; }
        public bool IsVisible { get; set; } = true;
        public List<Ticket> Tickets { get; set; } //NEW
    }
    internal class Hall 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Seats { get; set; }
        public List<Session> Sessions { get; set; }
    }
    internal class Ticket 
    {
        public int Id { get; set; }
        public int SeatNumber { get; set; }
        public string CustomerName { get; set; }
        public DateTime PurchasedAt { get; set; }

        public int SessionId { get; set; }
        public Session Session { get; set; }
    }

}
