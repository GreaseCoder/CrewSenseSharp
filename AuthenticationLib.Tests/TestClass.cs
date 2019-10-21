using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using CrewSenseNet.Authentication;
using System.Threading.Tasks;

namespace AuthenticationLib.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void ShouldParseTokenResponse()
        {
            var tokenManager = new TokenManager(new MockCrewSenseClient());
            var tokenResponse = tokenManager.GetToken("YOUR_CLIENT_ID", "YOUR_SECRET_KEY").Result;

            StringAssert.AreEqualIgnoringCase("DZs3IeaMP5uEAc2I19kJYl8Tbvsmgq9GaPQPaMjN", tokenResponse);
        }

        [Test]
        public void ShouldGetToken()
        {
            var tokenManager = new TokenManager(new CrewSenseClient());
            var token = tokenManager.GetToken("6t3TfkUIYJ", "8Mb1PUUVa7u84n5k5MPKpdsxDNti9z1p").Result;

        }
    }
}
