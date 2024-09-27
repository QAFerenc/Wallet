namespace Betsson.OnlineWallets.Tests;
using System.Net;
using System.Text.Json;
using RestSharp;
using System;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GetBalance_Test()
    {
        
        var baseUrl = "http://localhost:8080/onlinewallet/balance";
        RestClient client = new RestClient(baseUrl);
        RestRequest restRequest = new RestRequest(baseUrl, Method.Get);
        RestResponse restResponse = client.Execute(restRequest);
        Console.WriteLine(restResponse.StatusCode);  
    }

    [Test]
    public void Deoposit_Test()
    {

        //Current test tests only the response code, but not the transferred money (new balance - old balance)

        var baseUrl = "http://localhost:8080/onlinewallet/deposit";
        RestClient client = new RestClient(baseUrl);
        RestRequest restRequest = new RestRequest(baseUrl, Method.Post);
        restRequest.AddBody(new
        {
            amount = "27"
        });

        RestResponse restResponse = client.Execute(restRequest);
        Console.WriteLine(restResponse.StatusCode);
         
    
    }

    [Test]
    public void Withdraw_Test()
    {

        var baseUrl = "http://localhost:8080/onlinewallet/withdraw";
        RestClient client = new RestClient(baseUrl);
        RestRequest restRequest = new RestRequest(baseUrl, Method.Post);
        restRequest.AddBody(new
        {
            amount = "27"
        });

        RestResponse restResponse = client.Execute(restRequest);
        Console.WriteLine(restResponse.StatusCode);
    
    }
}