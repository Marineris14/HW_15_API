using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;

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
            SignInRequestModel body = new SignInRequestModel("mfjjnfj", "@", "Password123");
            RequestHelper requestHelper = new RequestHelper("/doregister");
            IRestResponse response = requestHelper.SendPostRequest(body);
            JObject json = JObject.Parse(response.Content);

            Assert.AreEqual("InternalServerError", response.StatusCode.ToString());

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

        [Test]

        public void CreateCompanyTestValidData()
        {
            Helper helper = new Helper();
            CreateCompanyModel body = new CreateCompanyModel()
            {
                CompanyName = "MarinerisLtd",
                CompanyType = "ООО",
                CompanyUsers = new List<string> { helper.GenerateEmail(), helper.GenerateEmail() },
                EmailOwner = "marineris@gmail.com"
            };
            RequestHelper requestHelper = new RequestHelper("/createcompany");
            IRestResponse response = requestHelper.SendPostRequest(body);
            JObject json = JObject.Parse(response.Content);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual(body.CompanyName, json["company"]["name"]?.ToString());
            Assert.AreEqual(body.CompanyType, json["company"]["type"]?.ToString());
        }

        [TestCase ("MarinerisLtd", "LTD", "marineris@gmail.com")]
        [TestCase("", "OOO", "marineris@gmail.com")]
        [TestCase("", "OOO", "marineris@gmail.com")]
        [TestCase("hjfdghdfn", "OOO", "marineris@gmail.com")]
        [TestCase("", "", "")]
        public void CreateCompanyTestInvalidData(string companyName, string companyType, string emailOwner)
        {
            Helper helper = new Helper();
            CreateCompanyModel body = new CreateCompanyModel()
            {
                CompanyName = companyName,
                CompanyType = companyType,
                EmailOwner = emailOwner
            };

            RequestHelper requestHelper = new RequestHelper("/createcompany");
            IRestResponse response = requestHelper.SendPostRequest(body);
            JObject json = JObject.Parse(response.Content);

            Assert.AreEqual("InternalServerError", response.StatusCode.ToString());
            Assert.AreEqual(HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Test]
        public void CreateCompanyTestEmptyData()
        {
            Helper helper = new Helper();
            CreateCompanyModel body = new CreateCompanyModel("", "", new List<string>() { "", "" }, "");
            RequestHelper requestHelper = new RequestHelper("/createcompany");
            IRestResponse response = requestHelper.SendPostRequest(body);
            JObject json = JObject.Parse(response.Content);

            Assert.AreEqual(null, json["company_name"]?.ToString());
            Assert.AreEqual(null, json["company_type"]?.ToString());
            Assert.AreEqual(null, json["company_users"]?.ToString());
            Assert.AreEqual(null, json["email_owner"]?.ToString());

        }

        [Test]
        public void CreateUserWithTasksTestValidData()
        {
            Helper helper = new Helper();
            CreateUserWithTasksModel body = new CreateUserWithTasksModel(helper.GenerateEmail(), helper.GenerateName(), new List<string> () { "first task", "second task" }, new List<int>() { 19, 20 }, "Kendo",
                "Lviv", "Parker", "Petrow", "Cat", "Dog", "Parrot", "Cavy", "Hamster", "Squirrel", "343 33 33", "143456789012", "m", "01.01.1900", "16,11.2021");
            RequestHelper requestHelper = new RequestHelper("/createuser");
            IRestResponse response = requestHelper.SendPostRequest(body);
            JObject json = JObject.Parse(response.Content);

            Assert.AreEqual("OK", response.StatusCode.ToString());

        }
    }
}
