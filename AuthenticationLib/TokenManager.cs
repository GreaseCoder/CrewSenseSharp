using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CrewSenseNet.Authentication
{
    public class TokenManager
    {
        private readonly ICrewSenseClient client;
        private readonly string clientId;
        private readonly string clientSecret;
        private DateTime expiration = DateTime.Now;

        public bool IsExpired() => expiration < DateTime.Now;

        public TokenManager(ICrewSenseClient client, string clientId, string clientSecret)
        {
            this.client = client;
            this.clientId = clientId;
            this.clientSecret = clientSecret;
        }

        public async Task<string> GetNewToken()
        {
            var tokenResponse = await GetTokenResponse();
            expiration = tokenResponse.Expires;

            return tokenResponse.AccessToken;
        }

        private async Task<AccessTokenResponse> GetTokenResponse()
        {
            var uri = new Uri("https://api.crewsense.com/oauth/access_token");
            var data = new Dictionary<string, string>
            {
                { "client_id", clientId },
                { "client_secret", clientSecret },
                { "grant_type", "client_credentials" }
            };
            
            var result = await client.DoPost(uri, data);
            var content = await result.Content.ReadAsStringAsync();

            try
            {
                return JsonSerializer.Deserialize<AccessTokenResponse>(content);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
