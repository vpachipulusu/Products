using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Products.Common.HttpProcessor
{
    public class TokenClient
    {
        public readonly IHttpClientFactory HttpClientFactory;

        public TokenClient(IHttpClientFactory httpClientFactory)
        {
            HttpClientFactory = httpClientFactory;
        }

        private static List<KeyValuePair<string, string>> ConstructTokenRequest(string clientId,
            string clientSecret, string grantType, string userName = "", string password = "")
        {
            List<KeyValuePair<string, string>> formContentValues = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("client_id", clientId),
                new KeyValuePair<string, string>("client_secret", clientSecret),
                new KeyValuePair<string, string>("grant_type", grantType),
                new KeyValuePair<string, string>("username", userName),
                new KeyValuePair<string, string>("password", password)
            };

            return formContentValues;
        }

        public async Task<AccessTokenDto> GetAccessTokenDetails(string uri, string clientId, string clientSecret,
            string grantType, string userName = "", string password = "")
        {
            var formContentValues = ConstructTokenRequest(clientId, clientSecret, grantType, userName, password);
            var response = await GetAccessTokenResponse(uri, formContentValues);
            var data = await response.Content.ReadAsStringAsync();
            var tokenDetails = JsonConvert.DeserializeObject<AccessTokenDto>(data);
            return tokenDetails;
        }

        private async Task<HttpResponseMessage> GetAccessTokenResponse(string uri,
            List<KeyValuePair<string, string>> formContentValues)
        {
            HttpRequestFactory.HttpClientFactory = HttpClientFactory;
            return await HttpRequestFactory.Post(uri, formContentValues, "");
        }
    }

    public class AccessTokenDto
    {
        [JsonProperty(PropertyName = "access_token")]
        public string Token { get; set; }

        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; set; }

        [JsonProperty(PropertyName = "expires_in")]
        public int ExpiresIn { get; set; }
    }
}
