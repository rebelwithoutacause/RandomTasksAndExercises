using NUnit.Framework;
using RestSharp;
using System.Net;
using Newtonsoft.Json.Linq;

namespace NewsApiTests
{
    public class NewsApiTests
    {
        public RestClient client;
        public const string apiKey = "7f9af39079d74b2a9f28eda31b862d89";

        [SetUp]
        public void Setup()
        {
            client = new RestClient("https://newsapi.org/v2");
        }

        [Test]
        public void GetTopHeadlines_ShouldReturn200()
        {
            var request = new RestRequest("top-headlines", Method.Get);
            request.AddParameter("country", "us");
            request.AddParameter("apiKey", apiKey);

            var response = client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var json = JObject.Parse(response.Content);
            Assert.That(json["status"].ToString(), Is.EqualTo("ok"));
            Assert.That((int)json["totalResults"], Is.GreaterThan(0));
        }

        [Test]
        public void SearchForKeyword_ShouldContainResults()
        {
            var request = new RestRequest("everything", Method.Get);
            request.AddParameter("q", "cybersecurity");
            request.AddParameter("sortBy", "publishedAt");
            request.AddParameter("apiKey", apiKey);

            var response = client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            var json = JObject.Parse(response.Content);
            Assert.That(json["articles"].HasValues, Is.True);
        }

        [Test]
        public void InvalidApiKey_ShouldReturn401()
        {
            var request = new RestRequest("top-headlines", Method.Get);
            request.AddParameter("country", "us");
            request.AddParameter("apiKey", "INVALID_API_KEY");

            var response = client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Unauthorized));

            var json = JObject.Parse(response.Content);
            Assert.That(json["status"].ToString(), Is.EqualTo("error"));
            Assert.That(json["code"].ToString(), Is.EqualTo("apiKeyInvalid"));
            Assert.That(json["message"].ToString(), Does.Contain("invalid or incorrect"));
        }


    }
}