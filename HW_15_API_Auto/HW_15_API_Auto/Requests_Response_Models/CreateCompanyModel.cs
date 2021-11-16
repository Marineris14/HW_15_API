using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tests_API
{
    public class CreateCompanyData
    {
        [JsonProperty("type")]
        public string StatusType { get; set; }

        [JsonProperty("messaga")]
        public string Message { get; set; }

        [JsonProperty("id_company")]
        public string IdCompany { get; set; }

        [JsonProperty("company")]
        public CreateCompanyModel CompanyData { get; set; }

    }
    public class CreateCompanyModel
    {
        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("company_type")]
        public string CompanyType { get; set; }

        [JsonProperty("company_users")]
        public List<string> CompanyUsers { get; set; }

        [JsonProperty("email_owner")]
        public string EmailOwner { get; set; }

        //public CreateCompanyModel(string company_name, string company_type, List<string> company_users, string email_owner)
        //{
        //    this.CompanyName = company_name;
        //    this.CompanyType = company_type;
        //    this.CompanyUsers = company_users;
        //    this.EmailOwner = email_owner;
        //}
    }
}
