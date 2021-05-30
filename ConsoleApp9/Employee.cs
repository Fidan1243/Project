using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    [Serializable]
    class Employee : Human
    {
        [JsonRequired]
        public List<Cv> Cvs { get; set; } = new List<Cv>();
        public string Profecion { get; set; }
        public bool JoblessOrNot { get; set; } = false;
        private string FamilyStatus {  get; set; }
        public bool HaveFamily { get; set; } = false;
        public List<Vacancy> Notification { get; set; }
        public override string ToString()
        {
            Cv cv1 = new Cv();
            if(Cvs.Count > 0)
            {
                cv1 = Cvs.Find(s => s.Id == 1);
            }
            if (!JoblessOrNot)
            {
                FamilyStatus = "No";
            }
            else
            {
                FamilyStatus = "Yes";
            }
            return $@"Id: {Id}
Name: {Name}
Surname: {Surname}
Profecion: {Profecion}
University Accept Grade: {Age}
Work Time: {Phone}
Have family: {FamilyStatus}
Have Special Diplom: {cv1.HaveSpecialDiplom}";
        }
    }
}
