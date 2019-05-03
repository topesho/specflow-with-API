using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using RestSharp;
using Assert = NUnit.Framework.Assert;
//using FluentAssertions;

namespace TestSkill.API
{
    [TestClass]
    public class APITests
    {
        [TestMethod]
        public void APITestMethod()
        {
            var client = new RestClient("https://samples.openweathermap.org/data/2.5/weather?q=London,uk&appid=b6907d289e10d714a6e88b30761fae22");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("accept-encoding", "gzip, deflate");
            request.AddHeader("Host", "samples.openweathermap.org");
            request.AddHeader("Postman-Token", "f613d16d-fb34-4228-a76c-3d865935f149,e7286a80-4dc0-4399-b7c3-406ad0646db7");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.11.0");
            IRestResponse response = client.Execute(request);

            string status = response.StatusCode.ToString();
            //string errorMgs = response.ErrorMessage.ToString();
            string isSuccessful = response.IsSuccessful.ToString();
            int statusCode = (int)response.StatusCode;
            string content = response.Content.ToString();

            Assert.AreEqual(200, statusCode, "statusCode is  200");
            Assert.AreEqual("OK", status);
            if (!content.Contains("London")) Assert.IsTrue(content.Contains("London"));

            Assert.That(isSuccessful.Contains("true"), Is.False);

            Assert.That(content.Contains("London"), Is.True);         
        }



        }
    }

