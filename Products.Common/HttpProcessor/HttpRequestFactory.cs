using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Products.Common.HttpProcessor
{
    public static class HttpRequestFactory
    {
        public static IHttpClientFactory HttpClientFactory;

        public static async Task<HttpResponseMessage> Get(string requestUri, string apiKey)
            => await Get(requestUri, apiKey, "");

        public static async Task<HttpResponseMessage> Get(string requestUri, string apiKey, string bearerToken)
        {
            var builder = new HttpRequestBuilder(HttpClientFactory)
                                .AddMethod(HttpMethod.Get)
                                .AddRequestUri(requestUri)
                                .AddBearerToken(bearerToken)
                                .AddApiKeyHeader(apiKey);

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> Get(
            string requestUri, List<KeyValuePair<string, string>> queryParameters, string apiKey)
        {
            var builder = new HttpRequestBuilder(HttpClientFactory)
                .AddMethod(HttpMethod.Get)
                .AddRequestUri(requestUri)
                .AddQueryParameters(queryParameters)
                .AddApiKeyHeader(apiKey);

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> Post(string requestUri, object value, string apiKey)
        {
            var builder = new HttpRequestBuilder(HttpClientFactory)
                .AddMethod(HttpMethod.Post)
                .AddRequestUri(requestUri)
                .AddContent(new JsonContent(value))
                .AddApiKeyHeader(apiKey);

            return await builder.SendAsync();
        }


        public static async Task<HttpResponseMessage> Post(
            string requestUri, JsonContent value, string bearerToken)
        {
            if (string.IsNullOrEmpty(bearerToken))
            {
                throw new Exception("Token is empty.");
            }

            var builder = new HttpRequestBuilder(HttpClientFactory)
                .AddMethod(HttpMethod.Post)
                .AddRequestUri(requestUri)
                .AddContent(value)
                .AddBearerToken(bearerToken);

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> Post(
            string requestUri, string bearerToken)
        {
            if (string.IsNullOrEmpty(bearerToken))
            {
                throw new Exception("Token is empty.");
            }

            var builder = new HttpRequestBuilder(HttpClientFactory)
                .AddMethod(HttpMethod.Post)
                .AddRequestUri(requestUri)
                .AddBearerToken(bearerToken);

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> Post(
            string requestUri, List<KeyValuePair<string, string>> formContentValues, string apiKey)
        {
            var builder = new HttpRequestBuilder(HttpClientFactory)
                .AddMethod(HttpMethod.Post)
                .AddRequestUri(requestUri)
                .AddFormContentValues(formContentValues)
                .AddApiKeyHeader(apiKey);

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> Post(
            string requestUri, List<KeyValuePair<string, string>> formContentValues, object value)
        {
            var builder = new HttpRequestBuilder(HttpClientFactory)
                .AddMethod(HttpMethod.Post)
                .AddRequestUri(requestUri)
                .AddFormContentValues(formContentValues)
                .AddContent(new JsonContent(value));

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> Post(
            string requestUri, HttpContent value, string bearerToken)
        {
            var builder = new HttpRequestBuilder(HttpClientFactory)
                .AddMethod(HttpMethod.Post)
                .AddRequestUri(requestUri)
                .AddContent(value)
                .AddBearerToken(bearerToken);

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> Put(string requestUri, object value)
            => await Put(requestUri, value, "");

        public static async Task<HttpResponseMessage> Put(
            string requestUri, object value, string apiKey)
        {
            var builder = new HttpRequestBuilder(HttpClientFactory)
                                .AddMethod(HttpMethod.Put)
                                .AddRequestUri(requestUri)
                                .AddContent(new JsonContent(value))
                                .AddApiKeyHeader(apiKey);

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> Put(
            string requestUri)
        {
            var builder = new HttpRequestBuilder(HttpClientFactory)
                .AddMethod(HttpMethod.Put)
                .AddRequestUri(requestUri);

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> Put(
            string requestUri, JsonContent value, string bearerToken)
        {
            var builder = new HttpRequestBuilder(HttpClientFactory)
                .AddMethod(HttpMethod.Put)
                .AddRequestUri(requestUri)
                .AddContent(value)
                .AddBearerToken(bearerToken);

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> Patch(string requestUri, object value)
            => await Patch(requestUri, value, "");

        public static async Task<HttpResponseMessage> Patch(
            string requestUri, object value, string bearerToken)
        {
            var builder = new HttpRequestBuilder(HttpClientFactory)
                                .AddMethod(new HttpMethod("PATCH"))
                                .AddRequestUri(requestUri)
                                .AddContent(new PatchContent(value))
                                .AddBearerToken(bearerToken);

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> Delete(string requestUri)
            => await Delete(requestUri, "");

        public static async Task<HttpResponseMessage> Delete(
            string requestUri, string apiKey)
        {
            var builder = new HttpRequestBuilder(HttpClientFactory)
                                .AddMethod(HttpMethod.Delete)
                                .AddRequestUri(requestUri)
                                .AddApiKeyHeader(apiKey);

            return await builder.SendAsync();
        }

        public static async Task<HttpResponseMessage> PostFile(string requestUri,
            string filePath, string apiParamName)
            => await PostFile(requestUri, filePath, apiParamName, "");

        public static async Task<HttpResponseMessage> PostFile(string requestUri,
            string filePath, string apiParamName, string bearerToken)
        {
            var builder = new HttpRequestBuilder(HttpClientFactory)
                                .AddMethod(HttpMethod.Post)
                                .AddRequestUri(requestUri)
                                .AddContent(new FileContent(filePath, apiParamName))
                                .AddBearerToken(bearerToken);

            return await builder.SendAsync();
        }
    }
}
