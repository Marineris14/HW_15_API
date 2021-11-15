using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tests_API
{
    public class CreateCompanyModel
    {
        [JsonProperty("company_name")]
        public string Company_name { get; set; }

        [JsonProperty("company_type")]
        public string Company_type { get; set; }

        [JsonProperty("company_users")]
        public List<string> Company_users { get; set; }

        [JsonProperty("email_owner")]
        public string Email_owner { get; set; }

        public CreateCompanyModel(string company_name, string company_type, List<string> company_users, string email_owner)
        {
            this.Company_name = company_name;
            this.Company_type = company_type;
            this.Company_users = company_users;
            this.Email_owner = email_owner;
        }
    }
}
