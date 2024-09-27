//using NUnit.Framework;
//using Prime.Services;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

using RestSharp;

namespace WalletTests
{
[TestClass]
public class tests
{
    [TestMethod]
    public async Task GET_wallet()
    {
        await using var application = new WebApplicationFactory<Api.Startup>();
        using var client = application.CreateClient();
 
        var response = await client.GetAsync("/onlinewallet/balance");
        response.StatusCode.Should().Be(HttpStatusCode.OK);
          Console.WriteLine("Hello world !");
    }
    
}
}