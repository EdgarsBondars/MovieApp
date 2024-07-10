using MovieApp.Server.Endpoints;

namespace MovieApp.Server.Logic
{
    /// <summary>
    /// Logic for interacting with the OMDB API.
    /// </summary>
    public class OmdbLogic : IOmbdLogic
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpClientHandler _httpHandler;

        /// <summary>
        /// Initializes a new instance of the <see cref="OmdbLogic"/> class with the specified configuration and HTTP handler.
        /// </summary>
        /// <param name="configuration">The configuration settings.</param>
        /// <param name="httpHandler">The HTTP handler for making API requests.</param>
        public OmdbLogic(IConfiguration configuration, IHttpClientHandler httpHandler)
        {
            _configuration = configuration;
            _httpHandler = httpHandler;
        }

        /// <summary>
        /// Retrieves movies from OMDB by title.
        /// </summary>
        /// <param name="movieTitle">The title of the movie to search for.</param>
        /// <returns>A task representing the asynchronous operation, with a string containing the search results.</returns>
        public async Task<string> GetMoviesByTitle(string movieTitle)
        {
            if (movieTitle == string.Empty)
            {
                return string.Empty;
            }

            HttpResponseMessage response = await _httpHandler.GetAsync(OmdbApi.SearchMovies(_configuration["OmdbApiKey"], movieTitle));
            return await response.Content.ReadAsStringAsync();
        }

        /// <summary>
        /// Retrieves a movie from OMDB by its ID.
        /// </summary>
        /// <param name="omdbId">The OMDB ID of the movie to retrieve.</param>
        /// <returns>A task representing the asynchronous operation, with a string containing the movie details.</returns>
        public async Task<string> GetMovieByOmdbId(string omdbId)
        {
            if (omdbId == string.Empty)
            {
                return string.Empty;
            }

            HttpResponseMessage response = await _httpHandler.GetAsync(OmdbApi.MovieById(_configuration["OmdbApiKey"], omdbId));
            return await response.Content.ReadAsStringAsync();
        }
    }
}
