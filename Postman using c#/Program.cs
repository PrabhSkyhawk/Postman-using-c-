using System;
using RestSharp;
using System.Threading.Tasks;

namespace HelloWorldApplication
{
    public static class HelloWorld
    {
        static async Task Main(string[] args)
        {
            await Main1();
            await Main2();
            await Main3();
            await Main4();
            await Main5();
            await Main6();
            await Main7();
            await Main8();
            await Main9();
            await Main10();
            await Main11();
            await Main12();
        }


        static async Task Main1()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/users?page=2", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }

        static async Task Main2()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/users/2", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }

        static async Task Main3()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/users/23", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }

        static async Task Main4()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/unknown", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }

        static async Task Main5()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/unknown/2", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }

        static async Task Main6()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/unknown/23", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }

        static async Task Main7()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/users", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
            @"    ""name"": ""morpheus"",
" + "\n" +
            @"    ""job"": ""leader""
" + "\n" +
            @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }

        static async Task Main8()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/register", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
            @"    ""email"": ""eve.holt@reqres.in"",
" + "\n" +
            @"    ""password"": ""pistol""
" + "\n" +
            @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }

        static async Task Main9()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/register", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
            @"    ""email"": ""sydney@fife""
" + "\n" +
            @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }

        static async Task Main10()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/login", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
            @"    ""email"": ""eve.holt@reqres.in"",
" + "\n" +
            @"    ""password"": ""cityslicka""
" + "\n" +
            @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }

        static async Task Main11()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/login", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
            @"    ""email"": ""peter@klaven""
" + "\n" +
            @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }

        static async Task Main12()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/users/2", Method.Put);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
            @"    ""name"": ""morpheus"",
" + "\n" +
            @"    ""job"": ""zion resident""
" + "\n" +
            @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }
    }
}