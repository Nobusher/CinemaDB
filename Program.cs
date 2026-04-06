using CinemaDB.Models;

namespace CinemaDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var db = new CinemaContext();
            
            //Индексы могут не совпадать,проверяйте вручную в psql,
            //либо указывайте через ссылку на экземпляр
            /*var action = AddGenre("Action");
            var scifi = AddGenre("SciFi");
            var drama = AddGenre("Drama");

            db.Genres.AddRange(action, scifi, drama);
            db.SaveChanges();
            var cubrick = AddDirector("Stanley Kubrick", "USA");
            var sergei = AddDirector("Сергей Акобян", "Armenia");
            var arseny = AddDirector("Арсений Гришин", "USA");

            db.Directors.AddRange(cubrick, sergei, arseny);
            db.SaveChanges();
            var hall1 = AddHall("Hall 1", 100);
            var hall2 = AddHall("Hall 2", 50);
            var hallVIP = AddHall("Hall VIP", 20);

            db.Halls.AddRange(hall1, hall2, hallVIP);

            db.SaveChanges();

            var shining = AddFilm("The Shining", 1980, 146, 10, 3, true);
            var train = AddFilm("The train to Erevan", 1950, 162, 11, 3, true);
            var nowayhome = AddFilm("No way home", 2022, 212, 12, 3, true);

            db.Films.AddRange(shining, train, nowayhome);

            db.SaveChanges();

            db.Sessions.AddRange
                (
                AddSession(shining, hall1, DateTime.UtcNow, 500, false),
                AddSession(train, hallVIP, DateTime.UtcNow.AddDays(1), 3500, true),
                AddSession(train, hall2, DateTime.UtcNow.AddDays(1), 1500, true),
                AddSession(nowayhome, hallVIP, DateTime.UtcNow.AddDays(2), 3500, true),
                AddSession(nowayhome, hallVIP, DateTime.UtcNow.AddDays(2), 3500, true)
                );
            db.SaveChanges();
            Console.WriteLine("Database filled!!!");
        }
        static Genre AddGenre(string name)
        {
            return new Genre { Name = name };
        }
        static Director AddDirector(string name, string country)
        {
            return new Director { Name = name, Country = country };
        }
        static Hall AddHall(string name, int seats)
        {
            return new Hall { Name = name, Seats = seats };
        }
        static Film AddFilm(string title, int year,
            int duration, int directorid, int genreid, bool visible)
        {
            return new Film
            {
                Title = title,
                Year = year,
                Duration = duration,
                DirectorId = directorid,
                GenreId = genreid,
                IsVisible = visible
            };
        }
        static Session AddSession(Film film, Hall hall, DateTime dateTime,
            decimal price, bool isvisible)
        {
            return new Session
            {
                DateTime = dateTime,
                Film = film,
                Hall = hall,
                Price = price,
                IsVisible = isvisible
            };*/
        }


        
    }
}
