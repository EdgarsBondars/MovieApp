namespace MovieApp.Server
{
    /// <summary>
    /// Handles HTTP client operations.
    /// </summary>
    public interface IHttpClientHandler
    {
        /// <summary>
        /// Sends a synchronous GET request to the specified URL.
        /// </summary>
        /// <param name="url">The URL to send the GET request to.</param>
        /// <returns>The HTTP response message.</returns>
        HttpResponseMessage Get(string url);

        /// <summary>
        /// Sends a synchronous POST request to the specified URL with the given content.
        /// </summary>
        /// <param name="url">The URL to send the POST request to.</param>
        /// <param name="content">The content to send in the POST request.</param>
        /// <returns>The HTTP response message.</returns>
        HttpResponseMessage Post(string url, HttpContent content);

        /// <summary>
        /// Sends an asynchronous GET request to the specified URL.
        /// </summary>
        /// <param name="url">The URL to send the GET request to.</param>
        /// <returns>A task representing the asynchronous operation, with a HTTP response message as the result.</returns>
        Task<HttpResponseMessage> GetAsync(string url);

        /// <summary>
        /// Sends an asynchronous POST request to the specified URL with the given content.
        /// </summary>
        /// <param name="url">The URL to send the POST request to.</param>
        /// <param name="content">The content to send in the POST request.</param>
        /// <returns>A task representing the asynchronous operation, with a HTTP response message as the result.</returns>
        Task<HttpResponseMessage> PostAsync(string url, HttpContent content);
    }
}