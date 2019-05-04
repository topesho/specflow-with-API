using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using RestSharp;
using System;
using System.Linq;
using TechTalk.SpecFlow;
using Assert = NUnit.Framework.Assert;

namespace TestSkill.StepDefinitions
{
    [Binding]
    public class APITestWithSpecflow
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;
        

           [Given(@"I have entered my endpoint")]
        public void GivenIHaveEnteredMyEndpoint()
        {
            string url =  ("https://samples.openweathermap.org/data/2.5/weather?q=London,uk&appid=b6907d289e10d714a6e88b30761fae22");
            client = new RestClient(url);

        }

        [Given(@"I send a ""(.*)""")]
        public void GivenISendA(string p0)
        {
            request = new RestRequest(Method.GET);
        }
        
        [When(@"I execute the response")]
        public void WhenIExecuteTheResponse()
        {
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("accept-encoding", "gzip, deflate");
            request.AddHeader("Host", "samples.openweathermap.org");
            request.AddHeader("Postman-Token", "f613d16d-fb34-4228-a76c-3d865935f149,e7286a80-4dc0-4399-b7c3-406ad0646db7");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.11.0");
            response = client.Execute(request);
        }
        
        [Then(@"the response should be successful")]
        public void ThenTheResponseShouldBeSuccessful()
        {
            string status = response.StatusCode.ToString();
            //string errorMgs = response.ErrorMessage.ToString();
            string isSuccessful = response.IsSuccessful.ToString();
            int statusCode = (int)response.StatusCode;
            string content = response.Content.ToString();

            Assert.AreEqual(200, statusCode, "statusCode is  200");
            Assert.That(response.StatusCode.ToString().Equals("OK"), Is.True);

            Assert.AreEqual("OK", status);
            if (!content.Contains("London")) Assert.IsTrue(content.Contains("London"));

            Assert.That(isSuccessful.Contains("true"), Is.False);

            Assert.That(content.Contains("London"), Is.True);
        }

        [Given(@"I have entered my invalid endpoint")]
        public void GivenIHaveEnteredMyInvalidEndpoint()
        {
            client = new RestClient("https://samples.openweathermap.org/data//weather?q=London,uk&appid=b6907d289e10d714a6e88b30761fae22");
        }

        [When(@"I execute the response with invalid endpoint")]
        public void WhenIExecuteTheResponseWithInvalidEndpoint()
        {
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("accept-encoding", "gzip, deflate");
            request.AddHeader("Host", "samples.openweathermap.org");
            request.AddHeader("Postman-Token", "fd2bf31e-3b59-46bb-9789-9af9599b7ed8,a3ec6d09-892d-4b82-a527-05ee279f9021");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.11.0");
            response = client.Execute(request);
        }


        [Then(@"the response should be unsuccessful")]
        public void ThenTheResponseShouldBeUnsuccessful()
        {
            Assert.That(response.StatusCode.ToString().Contains("NotFound"), Is.True);
            Assert.That(response.Headers.Count().Equals(7), Is.True);
            Assert.AreEqual(response.Content, "");
            
        }


    }
}
