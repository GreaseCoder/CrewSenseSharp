using AuthenticationLib.Tests;
using CrewSenseNet.Authentication;
using DataAccessLib;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class GetScheduleTests
    {
        private readonly string clientId;
        private readonly string clientSecret;

        public GetScheduleTests()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.secret.json")
                .Build();

            clientId = config.GetSection("ClientId").Value;
            clientSecret = config.GetSection("ClientSecret").Value;
        }

        [Test]
        public void ShouldGetSchedule()
        {
            var tokenManager = new TokenManager(new BasicRealClient(), clientId, clientSecret);
            var dataAccess = new DataAccess(new CrewSenseClient(tokenManager));
            var schedule = dataAccess.GetSchedule(DateTime.Now.AddDays(-5), DateTime.Now).Result;
        }
    }
}