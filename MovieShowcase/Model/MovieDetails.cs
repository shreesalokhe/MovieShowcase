using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model
{
    public class MovieDetails
    {
        public string[] Directors { get; set; }

        public DateTime Release_date { get; set; }

        public double Rating { get; set; }

        public string[] Genres { get; set; }

        public string Image_url { get; set; }

        public string Plot { get; set; }

        public string Rank { get; set; }

        public int Running_time_secs { get; set; }

        public string[] Actors { get; set; }
    }
}
