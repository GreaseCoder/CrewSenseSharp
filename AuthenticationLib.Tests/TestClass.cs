using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using CrewSenseNet.Authentication;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;

namespace AuthenticationLib.Tests
{
    [TestFixture]
    public class TestClass
    {
        private readonly string clientId;
        private readonly string clientSecret;

        public TestClass()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.secret.json")
                .Build();

            clientId = config.GetSection("ClientId").Value;
            clientSecret = config.GetSection("ClientSecret").Value;
        }

        [Test]
        public void ShouldGetToken()
        {
            var tokenManager = new TokenManager(new BasicClient(), clientId, clientSecret);
            var token = tokenManager.GetNewToken().Result;

        }
    }

    public class BasicClient : ICrewSenseClient
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
