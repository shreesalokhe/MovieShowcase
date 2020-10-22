using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model
{
    public class Movie
    {
        public int Year { get; set; }
        public string Title { get; set; }
        public MovieDetails Info { get; set; }
    }
}
