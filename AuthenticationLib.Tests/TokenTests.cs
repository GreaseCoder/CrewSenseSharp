using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using CrewSenseNet.Authentication;
using Microsoft.Extensions.Configuration;
using System;

namespace AuthenticationLib.Tests
{
    [TestFixture]
    public class TokenTests
    {
        private readonly string clientId;
        private readonly string clientSecret;

        public TokenTests()
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
            var tokenManager = new TokenManager(new BasicRealClient(), clientId, clientSecret);
            var token = tokenManager.GetNewToken().Result;

        }
    }

}
