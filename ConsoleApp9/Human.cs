using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    abstract class Human 
    {
        [JsonRequired]
        public int Id { get; set; }
        [JsonRequired]
        public string Name { get; set; }
        [JsonRequired]
        public string Surname { get; set; }
        [JsonRequired]
        public string Password { get; set; }
        [JsonRequired]
        public string Phone { get; set; }
        [JsonRequired]
        public int Age { get; set; }

    }
}
