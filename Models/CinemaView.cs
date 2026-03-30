using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDB.Models
{
    internal class CinemaView
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DirectorName { get; set; }
        public string GenreName { get; set; }
        public string HallName { get; set; }
        public DateTime Datetime {get;set;}
        public decimal Price { get; set; }
    }
}
