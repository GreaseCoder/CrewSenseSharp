using AuthenticationLib;
using CrewSenseNet.Authentication;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace AuthenticationLib.Tests
{
    class MockCrewSenseClient : ICrewSenseClient
    {
        public Task<HttpResponseMessage> DoGet(Uri uri, Dictionary<string, string> data)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> DoPost(Uri uri, Dictionary<string, string> data)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetTokenResponseString(string clientId, string clientSecret)
        {
            return Task.FromResult<string>(
                "{" +
                "   \"access_token\": \"DZs3IeaMP5uEAc2I19kJYl8Tbvsmgq9GaPQPaMjN\"," +
                "   \"token_type\": \"bearer\"," +
                "   \"expires\": 1426274440," +
                "   \"expires_in\": 86400" +
                "}");
        }
    }
}
