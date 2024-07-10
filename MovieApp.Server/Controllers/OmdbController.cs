using Microsoft.AspNetCore.Mvc;
using MovieApp.Server.Logic;

namespace MovieApp.Server.Controllers
{
    /// <summary>
    /// Controller for handling OMDB API requests.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class OmdbController
    {
        private readonly IOmbdLogic _omdbLogic;

        /// <summary>
        /// Initializes a new instance of the <see cref="OmdbController"/> class with the specified OMDB logic.
        /// </summary>
        /// <param name="omdbLogic">The logic for interacting with the OMDB API.</param>
        public OmdbController(IOmbdLogic omdbLogic)
        {
            _omdbLogic = omdbLogic;
        }

        /// <summary>
        /// Retrieves movies by title.
        /// </summary>
        /// <param name="movieTitle">The title of the movie to search for.</param>
        [HttpGet("GetMovies/{movieTitle}")]
        public async Task<string> Get(string movieTitle)
        {
            return await _omdbLogic.GetMoviesByTitle(movieTitle);
        }

        /// <summary>
        /// Retrieves a movie by its OMDB ID.
        /// </summary>
        /// <param name="omdbId">The OMDB ID of the movie to retrieve.</param>
        [HttpGet("Movie/{omdbId}")]
        public async Task<string> GetMovie(string omdbId)
        {
            return await _omdbLogic.GetMovieByOmdbId(omdbId);
        }
    }
}
