using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tests_API
{
    public class CreateUserWithTasksModel
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tasks")]
        public List<string> Tasks { get; set; }

        [JsonProperty("companies")]
        public List<int> Companies { get; set; }

        [JsonProperty("hobby")]
        public string Hobby { get; set; }

        [JsonProperty("adres")]
        public string Adres { get; set; }

        [JsonProperty("name1")]
        public string Name1 { get; set; }

        [JsonProperty("surname1")]
        public string Surname1 { get; set; }

        [JsonProperty("fathername1")]
        public string Fathername1 { get; set; }

        [JsonProperty("cat")]
        public string Cat { get; set; }

        [JsonProperty("dog")]
        public string Dog { get; set; }

        [JsonProperty("parrot")]
        public string Parrot { get; set; }

        [JsonProperty("cavy")]
        public string Cavy { get; set; }

        [JsonProperty("hamster")]
        public string Hamster { get; set; }

        [JsonProperty("squirrel")]
        public string Squirrel { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("inn")]
        public string Inn { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }


        [JsonProperty("date_start")]
        public string DateStart { get; set; }

        public CreateUserWithTasksModel(string email, string name, List<string> tasks,
           List<int> companies, string hobby, string adres, string name1, string surname1,
            string fathername1, string cat, string dog, string parrot, string cavy, string hamster, 
            string squirrel, string phone, string inn, string gender, string birthday, string date_start)
        {
            this.Email = email;
            this.Name = name;
            this.Tasks = tasks;
            this.Companies = companies;
            this.Hobby = hobby;
            this.Adres = adres;
            this.Name1 = name1;
            this.Surname1 = surname1;
            this.Fathername1 = fathername1;
            this.Cat = cat;
            this.Dog = dog;
            this.Parrot = parrot;
            this.Cavy = cavy;
            this.Hamster = hamster;
            this.Squirrel = squirrel;
            this.Phone = phone;
            this.Inn = inn;
            this.Gender = gender;
            this.Birthday = birthday;
            this.DateStart = date_start;

        }

    }
}
