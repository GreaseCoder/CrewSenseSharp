using CrewSenseNet.Authentication;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationLib.Tests
{
    public class BasicRealClient : ICrewSenseClient
    {
        private readonly HttpClient client = new HttpClient();

        public async Task<HttpResponseMessage> DoGet(Uri uri, Dictionary<string, string> data)
        {
            return await client.GetAsync(uri);
        }

        public async Task<HttpResponseMessage> DoPost(Uri uri, Dictionary<string, string> data)
        {
            var content = new FormUrlEncodedContent(data);
            return await client.PostAsync(uri, content);
        }
    }
}
