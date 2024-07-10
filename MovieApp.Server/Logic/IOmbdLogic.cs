namespace MovieApp.Server.Logic
{
    /// <summary>
    /// Logic for interacting with the OMDB API.
    /// </summary>
    public interface IOmbdLogic
    {
        /// <summary>
        /// Retrieves movies from OMDB by title.
        /// </summary>
        /// <param name="movieTitle">The title of the movie to search for.</param>
        Task<string> GetMoviesByTitle(string movieTitle);

        /// <summary>
        /// Retrieves a movie from OMDB by its ID.
        /// </summary>
        /// <param name="omdbId">The OMDB ID of the movie to retrieve.</param>
        Task<string> GetMovieByOmdbId(string omdbId);
    }
}
