using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    [Serializable]
    class Vacancy
    {
        [JsonRequired]
        public int Id { get; set; }
        [JsonRequired]
        public string Employer { get; set; }
        [JsonRequired]
        public string Profecion { get; set; }
        [JsonRequired]
        public int UniAcceptGrade { get; set; }
        [JsonRequired]
        public string WorkTime { get; set; }
        [JsonRequired]
        public string ForeignLanguage { get; set; }
        [JsonRequired]
        public bool HaveSpecialDiplom { get; set; } = false;
        [JsonRequired]
        public string SpecialDiplom { get; private set; }
        [JsonRequired]
        public decimal Salary { get; set; }
        [JsonRequired]
        public string Description { get; set; }
        [JsonRequired]
        public List<Cv> Cvs { get; set; } = new List<Cv>();

        public override string ToString()
        {
            if (HaveSpecialDiplom)
            {
                SpecialDiplom = "Yes";
            }
            else
            {
                SpecialDiplom = "No";
            }
            return $@"Id: {Id}
Employer: {Employer}
Profecion: {Profecion}
University Accept Grade Must: {UniAcceptGrade}
Work Time: {WorkTime}
Foreign Language Must: {ForeignLanguage}
Do Need Special Diplom: {SpecialDiplom}
Salary: {Salary}
Description: {Description}";
        }
    }
}
