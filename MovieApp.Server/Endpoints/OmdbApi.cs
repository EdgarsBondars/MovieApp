namespace MovieApp.Server.Endpoints
{
    public static class OmdbApi
    {
        public static string BaseUrl = "http://www.omdbapi.com/";

        public static string WithApiKey(string apiKey)
        {
            return BaseUrl + $"?apikey={apiKey}&";
        }

        public static string MovieById(string apiKey, string movieId)
        {
            return WithApiKey(apiKey) + $"i={movieId}";
        }

        public static string SearchMovies(string apiKey, string movieTitle)
        {
            return WithApiKey(apiKey) + $"s={movieTitle}";
        }
    }
}
