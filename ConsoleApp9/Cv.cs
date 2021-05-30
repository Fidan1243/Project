using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    [Serializable]
    class Cv
    {
        [JsonRequired]
        public int Id { get; set; }
        [JsonRequired]
        public string Name { get; set; }
        [JsonRequired]
        public string Profecion { get; set; }
        [JsonRequired]
        public string School { get; set; }
        [JsonRequired]
        public int UniAcceptGrade { get; set; }
        [JsonRequired]
        public string Skills { get; set; }
        [JsonRequired]
        public string Companies { get; set; }
        [JsonRequired]
        public string WorkTime { get; set; }
        [JsonRequired]
        public string ForeignLanguage { get; set; }
        [JsonRequired]
        public bool HaveSpecialDiplom { get; set; } = false;
        [JsonRequired]
        public string SpecialDiplom { get; private set; }
        [JsonRequired]
        public string GitHubLink { get; set; }
        [JsonRequired]
        public string LinkedinUsername { get; set; }
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
Name: {Name}
School: {School}
Profecion: {Profecion}
University Accept Grade Must: {UniAcceptGrade}
Work Time: {WorkTime}
Foreign Language Must: {ForeignLanguage}
Do Need Special Diplom: {SpecialDiplom}
Skills: {Skills}
Companies: {Companies}
Github link: {GitHubLink}
Linkedin username: {LinkedinUsername}";
        }
    }
}
