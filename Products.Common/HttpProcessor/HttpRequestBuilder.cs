using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace Products.Common.HttpProcessor
{
    public class HttpRequestBuilder
    {
        private HttpMethod _method = null;
        private string _requestUri = "";
        private HttpContent _content = null;
        private string _bearerToken = "";
        private string _acceptHeader = "application/json";
        private TimeSpan _timeout = new TimeSpan(0, 0, 60);
        private List<KeyValuePair<string, string>> _formContentValues = null;
        private List<KeyValuePair<string, string>> _queryParameters = null;
        private string _apiKey = "";

        private readonly IHttpClientFactory _httpClientFactory;

        public HttpRequestBuilder(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public HttpRequestBuilder AddMethod(HttpMethod method)
        {
            _method = method;
            return this;
        }

        public HttpRequestBuilder AddRequestUri(string requestUri)
        {
            _requestUri = requestUri;
            return this;
        }

        public HttpRequestBuilder AddContent(HttpContent content)
        {
            _content = content;
            return this;
        }

        public HttpRequestBuilder AddBearerToken(string bearerToken)
        {
            _bearerToken = bearerToken;
            return this;
        }

        public HttpRequestBuilder AddAcceptHeader(string acceptHeader)
        {
            _acceptHeader = acceptHeader;
            return this;
        }

        public HttpRequestBuilder AddTimeout(TimeSpan timeout)
        {
            _timeout = timeout;
            return this;
        }

        public HttpRequestBuilder AddApiKeyHeader(string apiKey)
        {
            _apiKey = apiKey;
            return this;
        }

        public HttpRequestBuilder AddFormContentValues(List<KeyValuePair<string, string>> formContentValues)
        {
            _formContentValues = formContentValues;
            return this;
        }

        public HttpRequestBuilder AddQueryParameters(List<KeyValuePair<string, string>> queryParameters)
        {
            _queryParameters = queryParameters;
            return this;
        }

        public async Task<HttpResponseMessage> SendAsync()
        {
            using (var cancellationTokenSource = new CancellationTokenSource())
            {
                // Check required arguments
                EnsureArguments();

                // Set up request
                var request = new HttpRequestMessage
                {
                    Method = _method,
                    RequestUri = new Uri(_requestUri)
                };

                if (_content != null)
                    request.Content = _content;

                if (!string.IsNullOrEmpty(_bearerToken))
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _bearerToken);

                request.Headers.Accept.Clear();
                if (!string.IsNullOrEmpty(_acceptHeader))
                    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(_acceptHeader));

                if (!string.IsNullOrEmpty(_apiKey))
                    request.Headers.Add("ApiKey", _apiKey);

                if (_formContentValues != null && _formContentValues.Count > 0)
                    request.Content = new FormUrlEncodedContent(_formContentValues);

                if (_queryParameters != null && _queryParameters.Count > 0)
                {
                    FormUrlEncodedContent queryParameters = new FormUrlEncodedContent(_queryParameters);
                    request.RequestUri = new Uri($"{_requestUri}?{await queryParameters.ReadAsStringAsync()}");
                }

                // Setup client
                var client = _httpClientFactory.CreateClient();
                client.Timeout = _timeout;

                var response = await client.SendAsync(request, cancellationTokenSource.Token);

                if (response.IsSuccessStatusCode) return response;

                var content = await response.Content.ReadAsStringAsync();

                var exception = new Exception($"Error retrieving response. {response.StatusCode} {content}");
                throw exception;
            }
        }

        #region " Private "

        private void EnsureArguments()
        {
            if (_method == null)
                throw new ArgumentNullException($"Method");

            if (string.IsNullOrEmpty(_requestUri))
                throw new ArgumentNullException($"Request Uri");
        }

        #endregion
    }
}
