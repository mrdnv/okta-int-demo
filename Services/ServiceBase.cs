using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace okta_integration_demo.Services
{
    /// <summary>
    /// Base Service
    /// </summary>
    public abstract class ServiceBase
    {
        /// <summary>
        /// The HTTP client
        /// </summary>
        protected HttpClient httpClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceBase"/> class.
        /// </summary>
        /// <param name="httpClient">The HTTP client.</param>
        public ServiceBase(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            this.AddAuthorization();
        }

        private void AddAuthorization()
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("SSWS", "00fbWboezmonbKn03InXG9cZy2ioC-rDgKoODjpXMk");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        protected abstract string Url { get; }
    }
}
