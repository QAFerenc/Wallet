namespace Betsson.OnlineWallets.Tests;
using System.Net;
using System.Text.Json;
//using FluentAssertions;
using RestSharp;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Get_Test()
    {
        var baseUrl = "http://localhost:8080/onlinewallet/balance";
        RestClient client = new RestClient(baseUrl);
        RestRequest restRequest = new RestRequest(baseUrl, Method.Get);
        RestResponse restResponse = client.Execute(restRequest);
        Console.WriteLine(restResponse.StatusCode);
        //restResponse.Should().NotBeNull();
        //restResponse.StatusCode.S  .Should().Be(HttpStatusCode.BadRequest);
        
    }

    [Test]
    public void Post_Test()
    {

        var baseUrl = "http://localhost:8080/onlinewallet/deposit";
        RestClient client = new RestClient(baseUrl);
        RestRequest restRequest = new RestRequest(baseUrl, Method.Post);
        restRequest.AddBody(new
        {
            amount = "27"
        });

        RestResponse restResponse = client.Execute(restRequest);
        Console.WriteLine(restResponse.StatusCode);
        

        
        //Console.WriteLine("Hello Laci !");
        //Assert.Pass();
        
        //Console.WriteLine("Hello World !");
    }
}