using API.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace TestAPI
{
    [TestClass]
    public class MovieControllerTest
    {
        private MoviesDataController moviesDataController;
        [TestInitialize]
        public void InitializeData()
        {
            moviesDataController = new MoviesDataController();
        }

        [TestMethod]
        public void GetAllMovies()
        {
            var result = moviesDataController.GetAllMovies();
            bool status = result.Count() > 1 ? true : false;
            Assert.AreEqual(status, true);
        }

        public void GetYearWiseMovies()
        {
            var result = moviesDataController.GetMoviesByYear(2013);
            bool status = result.Count() > 1 ? true : false;
            Assert.AreEqual(status, true);
        }
    }
}
