namespace MovieApp.Server
{
    /// <summary>
    /// Handles HTTP client operations.
    /// </summary>
    public class HttpClientHandler : IHttpClientHandler
    {
        private HttpClient _client;

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpClientHandler"/> class with the specified <see cref="HttpClient"/>.
        /// </summary>
        /// <param name="httpClient">The HTTP client to use for making requests.</param>
        public HttpClientHandler(HttpClient httpClient)
        {
            _client = httpClient;
        }

        /// <summary>
        /// Sends a synchronous GET request to the specified URL.
        /// </summary>
        /// <param name="url">The URL to send the GET request to.</param>
        /// <returns>The HTTP response message.</returns>
        public HttpResponseMessage Get(string url)
        {
            return GetAsync(url).Result;
        }

        /// <summary>
        /// Sends a synchronous POST request to the specified URL with the given content.
        /// </summary>
        /// <param name="url">The URL to send the POST request to.</param>
        /// <param name="content">The content to send in the POST request.</param>
        /// <returns>The HTTP response message.</returns>
        public HttpResponseMessage Post(string url, HttpContent content)
        {
            return PostAsync(url, content).Result;
        }

        /// <summary>
        /// Sends an asynchronous GET request to the specified URL.
        /// </summary>
        /// <param name="url">The URL to send the GET request to.</param>
        /// <returns>A task representing the asynchronous operation, with a HTTP response message as the result.</returns>
        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            return await _client.GetAsync(url);
        }

        /// <summary>
        /// Sends an asynchronous POST request to the specified URL with the given content.
        /// </summary>
        /// <param name="url">The URL to send the POST request to.</param>
        /// <param name="content">The content to send in the POST request.</param>
        /// <returns>A task representing the asynchronous operation, with a HTTP response message as the result.</returns>
        public async Task<HttpResponseMessage> PostAsync(string url, HttpContent content)
        {
            return await _client.PostAsync(url, content);
        }
    }
}
