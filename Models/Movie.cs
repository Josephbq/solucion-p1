using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace solucion_p1.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime RealeaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}