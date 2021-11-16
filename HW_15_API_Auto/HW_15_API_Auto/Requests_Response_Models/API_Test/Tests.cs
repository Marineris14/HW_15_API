using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Tests_API
{
    class Testing_API
    {

        [Test]
        public void RegistrationTestValidData()
        {
            Helper helper = new Helper();
            SignInRequestModel body = new SignInRequestModel(helper.GenerateEmail(), helper.GenerateName(), "Password123");
            RequestHelper requestHelper = new RequestHelper("/doregister");
            IRestResponse response = requestHelper.SendPostRequest(body);
            JObject json = JObject.Parse(response.Content);
           
            Assert.AreEqual("OK", response.StatusCode.ToString());
           
        }

        [Test]
        public void RegistrationTestInvalidEmailAndName()
        {
            Helper helper = new Helper();
            SignInRequestModel body = new SignInRequestModel("mfjjnfj", "null", "Password123");
            RequestHelper requestHelper = new RequestHelper("/doregister");
            IRestResponse response = requestHelper.SendPostRequest(body);
            JObject json = JObject.Parse(response.Content);

            //Assert.AreEqual("OK", response.StatusCode.ToString());
            Assert.AreEqual(body.Name, json["name"]?.ToString());

        }

        [Test]
        public void RegistrationTestEmptyDataFields()
        {
            Helper helper = new Helper();
            SignInRequestModel body = new SignInRequestModel("", "", "");
            RequestHelper requestHelper = new RequestHelper("/doregister");
            IRestResponse response = requestHelper.SendPostRequest(body);
            JObject json = JObject.Parse(response.Content);

            Assert.AreEqual(null, json["email"]?.ToString());
            Assert.AreEqual(null, json["name"]?.ToString());

        }
    }
}
