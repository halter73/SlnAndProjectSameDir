using NUnit.Framework;
using Microsoft.AspNetCore.Mvc.Testing;

namespace MinimalTests
{
    [TestFixture]
    public class WebApplicationFactoryTests
    {
        [Test]
        public async Task TestWebApplicationFactoryWillThrowException()
        {
            var factory = new WebApplicationFactory<Program>();
            using (var client = factory.CreateClient())
            {
                var response = await client.GetAsync("");
            }
        }
    }
}
