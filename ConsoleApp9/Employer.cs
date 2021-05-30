using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    [Serializable]
    class Employer : Human
    {
        [JsonRequired]
        public List<Vacancy> Vacancies { get; set; } = new List<Vacancy>();
        [JsonRequired]
        public List<Cv> Cvs { get; set; } = new List<Cv>();

    }
}
