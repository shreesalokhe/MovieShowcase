using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using API.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MovieCors")]
    public class MoviesDataController : ControllerBase
    {
        private readonly List<Movie> movies = null;
        public MoviesDataController()
        {
            string movieData = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Files\moviedata.json");
            movies = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Movie>>(movieData);
        }

        // GET: api/<MoviesDataController>
        [HttpGet]
        [Route("GetMovies")]
        public IEnumerable<Movie> GetAllMovies()
        {
            return movies;
        }

        [HttpGet]
        [Route("GetMoviesDashboard")]
        public List<IEnumerable<Movie>> GetAllMoviesInTiles()
        {
            return movies.GroupBy(x => x.Year, (key, g) => g.OrderByDescending(e => e.Year).Take(4)).ToList();
        }

        // GET api/<MoviesDataController>/5
        [HttpGet]
        [Route("FindMoviesByYear")]
        public IEnumerable<Movie> GetMoviesByYear(int year)
        {
            return movies.Where(x => x.Year == year);
        }

        // POST api/<MoviesDataController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MoviesDataController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MoviesDataController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
