using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Starter
    {
        public void Start()
        {
            List<Employee> humans = new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Kuna",
                    Surname = "Gata",
                    Profecion = "Programmer",
                    Age = 19,
                    Cvs = new List<Cv>
                    {
                        new Cv
                        {
                            Name = "Kuna",
                            UniAcceptGrade = 99,
                            School = "F.Jerrod University",
                            Companies = "Creative Minds, Conceptualise and Iconica",
                            GitHubLink = "github.com/Matata254",
                            LinkedinUsername = "ImHakuna",
                            HaveSpecialDiplom = true,
                            ForeignLanguage = "English",
                            Profecion = "Programmer",
                            WorkTime = "12:00 - 00:00",
                            Id = 1
                        },
                        new Cv
                        {
                            Name = "Kuna",
                            UniAcceptGrade = 99,
                            School = "F.Jerrod University",
                            Companies = "Creative Minds, Conceptualise and Iconica",
                            GitHubLink = "github.com/Matata254",
                            LinkedinUsername = "ImHakuna",
                            HaveSpecialDiplom = true,
                            ForeignLanguage = "English",
                            Profecion = "Programmer",
                            WorkTime = "12:00 - 00:00",
                            Id = 2
                        },
                        new Cv
                        {
                            Name = "Kuna",
                            UniAcceptGrade = 99,
                            School = "F.Jerrod University",
                            Companies = "Creative Minds, Conceptualise and Iconica",
                            GitHubLink = "github.com/Matata254",
                            LinkedinUsername = "ImHakuna",
                            HaveSpecialDiplom = true,
                            ForeignLanguage = "English",
                            Profecion = "Programmer",
                            WorkTime = "12:00 - 00:00",
                            Id = 3
                        }
                    },
                    Phone = "202-555-0129",
                    Password = "gatata123"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Hakuna",
                    Surname = "Matata",
                    Profecion = "Design",
                    Age = 34,
                    Cvs = new List<Cv>
                    {
                        new Cv
                        {
                            Name = "Hakuna",
                            UniAcceptGrade = 99,
                            School = "F.Jerrod University",
                            GitHubLink = "github.com/Matata254",
                            LinkedinUsername = "ImHakuna",
                            HaveSpecialDiplom = true,
                            ForeignLanguage = "French",
                            Profecion = "Design",
                            WorkTime = "10:00 - 23:00",
                            Id = 1
                        },
                        new Cv
                        {
                            Name = "Hakuna",
                            UniAcceptGrade = 99,
                            School = "F.Jerrod University",
                            Companies = "Creative Minds, Conceptualise and Iconica",
                            GitHubLink = "github.com/Matata254",
                            LinkedinUsername = "ImHakuna",
                            HaveSpecialDiplom = true,
                            ForeignLanguage = "English",
                            Profecion = "Design",
                            WorkTime = "12:00 - 00:00",
                            Id = 2
                        }
                    },
                    Phone = "207-555-0118",
                    Password = "hakuna123"
                },
                new Employee
                {
                    Id = 3,
                    Name = "Cheap",
                    Surname = "Talk",
                    Profecion = "IT",
                    Age = 23,
                    Cvs = new List<Cv>
                    {
                        new Cv
                        {
                            Name = "Cheap",
                            UniAcceptGrade = 87,
                            School = "Vanderbilt University",
                            GitHubLink = "github.com/TalkDay",
                            LinkedinUsername = "ImHakuna",
                            HaveSpecialDiplom = true,
                            ForeignLanguage = "English",
                            Profecion = "IT",
                            WorkTime = "10:00 - 18:00",
                            Id = 1
                        },
                        new Cv
                        {
                            Name = "Cheap",
                            UniAcceptGrade = 99,
                            School = "F.Jerrod University",
                            Companies = "Creative Minds, Conceptualise and Iconica",
                            GitHubLink = "github.com/Matata254",
                            LinkedinUsername = "ImHakuna",
                            HaveSpecialDiplom = true,
                            ForeignLanguage = "English",
                            Profecion = "IT",
                            WorkTime = "12:00 - 00:00",
                            Id = 2
                        },
                        new Cv
                        {
                            Name = "Cheap",
                            UniAcceptGrade = 99,
                            School = "F.Jerrod University",
                            Companies = "Creative Minds, Conceptualise and Iconica",
                            GitHubLink = "github.com/Matata254",
                            LinkedinUsername = "ImHakuna",
                            HaveSpecialDiplom = true,
                            ForeignLanguage = "English",
                            Profecion = "Programmer",
                            WorkTime = "12:00 - 00:00",
                            Id = 3
                        },
                        new Cv
                        {
                            Name = "Cheap",
                            UniAcceptGrade = 99,
                            School = "F.Jerrod University",
                            Companies = "Creative Minds, Conceptualise and Iconica",
                            GitHubLink = "github.com/Matata254",
                            LinkedinUsername = "ImHakuna",
                            HaveSpecialDiplom = true,
                            ForeignLanguage = "English",
                            Profecion = "Programmer",
                            WorkTime = "12:00 - 00:00",
                            Id = 3
                        }
                    },
                    Phone = "307-555-0176",
                    Password = "sosial123"
                }
            };
            Employer employer = new Employer
            {
                Id = 1,
                Name = "Night",
                Surname = "Sight",
                Age = 39,
                Vacancies = new List<Vacancy>
                    {
                        new Vacancy()
                        {
                            Employer = "Night Sight",
                            UniAcceptGrade = 76,
                            Description = "This work is so serious. If you're married, please skip this vacancy",
                            HaveSpecialDiplom = true,
                            ForeignLanguage = "English (definitely)",
                            Profecion = "Design",
                            WorkTime = "10:00 - 23:00",
                            Salary = 2690,
                            Id = 1
                        },
                        new Vacancy()
                        {
                            Employer = "Night Sight",
                            UniAcceptGrade = 89,
                            Description = "This work is so serious. If you're married, please skip this vacancy",
                            HaveSpecialDiplom = true,
                            ForeignLanguage = "English (definitely)",
                            Profecion = "IT",
                            WorkTime = "10:00 - 23:00",
                            Salary = 2690,
                            Id = 1
                        },
                        new Vacancy()
                        {
                            Employer = "Night Sight",
                            UniAcceptGrade = 99,
                            Description = "If you're professional, you should check out this vacancy",
                            HaveSpecialDiplom = true,
                            ForeignLanguage = "English and Germany",
                            Profecion = "Programmer",
                            WorkTime = "10:00 - 23:00",
                            Salary = 4690,
                            Id = 1
                        },
                        new Vacancy()
                        {
                            Employer = "Night Sight",
                            UniAcceptGrade = 99,
                            Description = "If you have a time and have an interest, you can check out this vacancy!",
                            HaveSpecialDiplom = true,
                            ForeignLanguage = "French (definitely)",
                            Profecion = "Programmer",
                            WorkTime = "10:00 - 16:00",
                            Salary = 1390,
                            Id = 1
                        }
                    },
                Phone = "609-555-0140",
                Password = "night123"
            };

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            var findit = humans.Find(s => s.Name == name && s.Password == password);
            
            if (findit != null && !File.Exists($"{findit.Name}.json"))
            {
                Choose(ref findit, ref employer);                
            }
            else if (findit != null && File.Exists($"{findit.Name}.json"))
            {
                var serializer = new JsonSerializer();
                using (var sr = new StreamReader($"{findit.Name}.json"))
                {
                    using (var jr = new JsonTextReader(sr))
                    {
                        findit = serializer.Deserialize<Employee>(jr);
                    }
                }
                    Choose(ref findit, ref employer);
            }
            else if(employer.Name == name && employer.Password == password && !File.Exists($"{employer.Name}.json"))
            {
                Choose2(ref employer, ref humans);
            }
            else if (employer.Name == name && employer.Password == password && File.Exists($"{employer.Name}.json"))
            {
                var serializer = new JsonSerializer();
                using (var sr = new StreamReader($"{employer.Name}.json"))
                {
                    using (var jr = new JsonTextReader(sr))
                    {
                        employer = serializer.Deserialize<Employer>(jr);
                    }
                }
                Choose2(ref employer, ref humans);
            }
            else
            {
                throw new Exception("Invalid name or password");
            }
        }

        public void Choose(ref Employee employee, ref Employer employer)
        {
            Console.WriteLine("1) For Announcements");
            Console.WriteLine("2) For Cv Part");
            Console.WriteLine("3) For Notifications");
            string choose = Console.ReadLine();
            if (Convert.ToInt32(choose) == 1)
            {
                EmployeePartAnnouncement(ref employee, ref employer);
            }
            else if(Convert.ToInt32(choose) == 2)
            {
               EmployeePartCv(ref employee);
            }
            else if(Convert.ToInt32(choose) == 3)
            {
                if (employee.Notification == null)
                {
                    throw new Exception("There is not notification!");
                }
                else
                {
                    EmployeePartNotifications(ref employee);
                }

            }
            else
            {
                throw new Exception("Invalid choose");
            }
        }

        public void EmployeePartAnnouncement(ref Employee employee, ref Employer employer)
        {
            Console.Clear();
            string pr = employee.Profecion;
            var foremployee = employer.Vacancies.FindAll(s => s.Profecion == pr).ToList();
            foremployee.ForEach(s => Console.WriteLine(s));
            Console.Write("Enter Announcement Id: ");
            string id = Console.ReadLine();
            Console.Clear();
            employee.Cvs.ForEach(s => Console.WriteLine(s));
            Console.WriteLine("Enter Cv Id:");
            string eid = Console.ReadLine();
            var vd = employer.Vacancies.Find(s => s.Id == Convert.ToInt32(id));
            var dv = employee.Cvs.Find(s => s.Id == Convert.ToInt32(eid));
            if (vd != null && dv != null)
            {
                employer.Vacancies.Find(s => s.Id == Convert.ToInt32(id)).Cvs.Add(employee.Cvs.Find(s => s.Id == Convert.ToInt32(eid)));
                var serializer = new JsonSerializer();
                using (var sw = new StreamWriter($"{employer.Name}.json"))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                        serializer.Serialize(jw, employer);
                    }
                }
            }
            else
            {
                throw new Exception("Invalid Cv or Announcement ID");
            }
        }
        public void EmployeePartCv(ref Employee employee)
        {
            Console.Clear();
            Console.WriteLine("1) For Delete");
            Console.WriteLine("2) For Update");
            string ch = Console.ReadLine();
            
            if (Convert.ToInt32(ch) == 1 || Convert.ToInt32(ch) == 2)
            {
                if (Convert.ToInt32(ch) == 1)
                {
                    employee.Cvs.ForEach(s => Console.WriteLine(s));
                    Console.WriteLine("Enter Cv Id:");
                    string eid = Console.ReadLine();
                    if (employee.Cvs.Find(s=> s.Id == Convert.ToInt32(eid)) != null)
                    {
                        CvRemovePart(ref employee, eid);
                    }
                    else
                    {
                        throw new Exception("Invalid Choose");
                    }
                }
                else if (Convert.ToInt32(ch) == 2)
                {
                    employee.Cvs.ForEach(s => Console.WriteLine(s));
                    Console.WriteLine("Enter Cv Id:");
                    string eid = Console.ReadLine();
                    if (employee.Cvs.Find(s => s.Id == Convert.ToInt32(eid)) != null)
                    {
                        CvUpdatePart(ref employee, eid);
                    }
                    else
                    {
                        throw new Exception("Invalid Choose");
                    }
                }
                else
                {
                    throw new Exception("Invalid Choose");
                }
            }
            else
            {
                throw new Exception("Invalid Cv or Announcement ID");
            }
        }

        public void CvRemovePart(ref Employee employee, string id)
        {
            Console.Clear();
            employee.Cvs.RemoveAll(s=> s.Id == Convert.ToInt32(id));
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter($"{employee.Name}.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, employee);
                }
            }
        }
        public void EmployeePartNotifications(ref Employee employee)
        {
            Console.Clear();
            employee.Notification.ForEach(s => Console.WriteLine(s));
            Console.Write("Do you wanna start a job?: ");
            string yesno = Console.ReadLine();
            if (yesno == "yes")
            {
                Console.Write("Enter ID: ");
                string id = Console.ReadLine();
                if(employee.Notification.Find(s => s.Id == Convert.ToInt32(id)) != null)
                {
                    employee.JoblessOrNot = true;
                    employee.Notification.Remove(employee.Notification.Find(s => s.Id == Convert.ToInt32(id)));
                    var serializer = new JsonSerializer();
                    using (var sw = new StreamWriter($"{employee.Name}.json"))
                    {
                        using (var jw = new JsonTextWriter(sw))
                        {
                            jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                            serializer.Serialize(jw, employee);
                        }
                    }
                }
                else
                {
                    throw new Exception("Invalid ID");
                }
            }
            else if(yesno == "no")
            {
                employee.Notification = null;
                var serializer = new JsonSerializer();
                using (var sw = new StreamWriter($"{employee.Name}.json"))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                        serializer.Serialize(jw, employee);
                    }
                }
            }
            
        }
        public void EmployerPartNotifications(ref Employer employer, ref List<Employee> employee)
        {
            Console.Clear();
            employer.Cvs.ForEach(s => Console.WriteLine(s));
            Console.Write("Do you wanna start a job with someone?: ");
            string yesno = Console.ReadLine();
            if (yesno == "yes")
            {
                Console.Write("Enter ID: ");
                string id = Console.ReadLine();
                var nea = employer.Cvs.Find(s => s.Id == Convert.ToInt32(id));
                if (nea != null)
                {
                    var employeee = employee.Find(s => s.Name == nea.Name);
                    employeee.JoblessOrNot = true;
                    employer.Cvs.Remove(nea);
                    var serializer = new JsonSerializer();
                    using (var sw = new StreamWriter($"{employeee.Name}.json"))
                    {
                        using (var jw = new JsonTextWriter(sw))
                        {
                            jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                            serializer.Serialize(jw, employeee);
                        }
                    }
                    var serializer2 = new JsonSerializer();
                    using (var sw = new StreamWriter($"{employer.Name}.json"))
                    {
                        using (var jw = new JsonTextWriter(sw))
                        {
                            jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                            serializer2.Serialize(jw, employer);
                        }
                    }
                }
                else
                {
                    throw new Exception("Invalid ID");
                }
            }
            else if (yesno == "no")
            {
                employer.Cvs = null;
                var serializer = new JsonSerializer();
                using (var sw = new StreamWriter($"{employer.Name}.json"))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                        serializer.Serialize(jw, employer);
                    }
                }
            }

        }
        public void CvUpdatePart(ref Employee employee, string id)
        {
            Console.Clear();
            var cvr = employee.Cvs.Find(s => s.Id == Convert.ToInt32(id));
            Console.Write("Enter School");
            string sc = Console.ReadLine();
            Console.Write("Enter UniAccGr");
            string uniacc = Console.ReadLine();
            Console.Write("Enter WorkTime");
            string wt = Console.ReadLine();
            Console.Write("Enter ForeignL");
            string fl = Console.ReadLine();
            Console.Write("Enter SpcD:");
            string sd = Console.ReadLine();
            Console.Write("Enter Skills");
            string sk = Console.ReadLine();
            Console.Write("Enter Cmpn");
            string cp = Console.ReadLine();
            Console.Write("Enter Linkdn");
            string ll = Console.ReadLine();
            Console.Write("Enter Fithub");
            string gl = Console.ReadLine();

            int CvId = employee.Cvs.Count;

            cvr.School = sc;
            cvr.UniAcceptGrade = Convert.ToInt32(uniacc);
            cvr.WorkTime = wt;
            cvr.ForeignLanguage = fl;
            cvr.HaveSpecialDiplom = Convert.ToBoolean(sd);
            cvr.Skills = sk;
            cvr.Companies = cp;
            cvr.LinkedinUsername = ll;
            cvr.GitHubLink = gl;
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter($"{employee.Name}.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, employee);
                }
            }
        }
        public void Choose2(ref Employer employer, ref List<Employee> employee)
        {
            Console.Clear();
            Console.WriteLine("1) For Employee");
            Console.WriteLine("2) For Vacancies Part");
            Console.WriteLine("3) For Notifications");
            string choose = Console.ReadLine();
            if (Convert.ToInt32(choose) == 1)
            {
                EmployerPartEmployee(ref employer, ref employee);
            }
            else if (Convert.ToInt32(choose) == 2)
            {
                EmployerPartVacancies(ref employer);
            }
            else if (Convert.ToInt32(choose) == 3)
            {
                EmployerPartNotifications(ref employer, ref employee);

            }
            else
            {
                throw new Exception("Invalid choose");
            }
        }

        public void EmployerPartEmployee(ref Employer employer, ref List<Employee> employee)
        {
            Console.Clear();
            var Itemp = employee.FindAll(s => s.Profecion == "IT" && s.JoblessOrNot == false);
            var PRemp = employee.FindAll(s => s.Profecion == "Programmer" && s.JoblessOrNot == false);
            var DSemp = employee.FindAll(s => s.Profecion == "Design" && s.JoblessOrNot == false);
            Console.WriteLine("1) For Look for IT employee");
            Console.WriteLine("2) For Look for Programmer employee");
            Console.WriteLine("3) For Look for Design employee");
            string ch = Console.ReadLine();
            if (Convert.ToInt32(ch) == 1)
            {
                Console.Clear();
                Itemp.ForEach(s => {
                    Console.WriteLine("================================");
                    Console.WriteLine(s);
                });
                Console.Write("Enter Employee ID: ");
                string id = Console.ReadLine();

                var eit = employer.Vacancies.FindAll(s => s.Profecion == "IT");
                eit.ForEach(s => {
                    Console.WriteLine("================================");
                    Console.WriteLine(s);
                });
                Console.WriteLine("Enter Vacancy ID: ");
                string vid = Console.ReadLine();
                if (Itemp.Find(s=> s.Id == Convert.ToInt32(id)) != null && employer.Vacancies.Find(s => s.Id == Convert.ToInt32(id)) != null)
                {
                    Itemp.Find(s => s.Id == Convert.ToInt32(id)).Notification = new List<Vacancy>();
                    Itemp.Find(s => s.Id == Convert.ToInt32(id)).Notification.Add(employer.Vacancies.Find(s => s.Id == Convert.ToInt32(id)));
                    var serializer = new JsonSerializer();
                    using (var sw = new StreamWriter($"{Itemp.Find(s => s.Id == Convert.ToInt32(id)).Name}.json"))
                    {
                        using (var jw = new JsonTextWriter(sw))
                        {
                            jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                            serializer.Serialize(jw, Itemp.Find(s => s.Id == Convert.ToInt32(id)));
                        }
                    }
                }
                else
                {
                    throw new Exception("Invalid Vacancy or Employee ID");
                }
            }

            else if (Convert.ToInt32(ch) == 2)
            {
                Console.Clear();
                PRemp.ForEach(s => {
                    Console.WriteLine("================================");
                    Console.WriteLine(s);
                });
                Console.Write("Enter Employee ID: ");
                string id = Console.ReadLine();
                Console.Clear();
                var epr = employer.Vacancies.FindAll(s => s.Profecion == "Programmer");
                epr.ForEach(s => {
                    Console.WriteLine("================================");
                    Console.WriteLine(s);
                });
                Console.WriteLine("Enter Vacancy ID: ");
                string vid = Console.ReadLine();
                if (PRemp.Find(s => s.Id == Convert.ToInt32(id)) != null && employer.Vacancies.Find(s => s.Id == Convert.ToInt32(id)) != null)
                {
                    PRemp.Find(s => s.Id == Convert.ToInt32(id)).Notification = new List<Vacancy>();
                    PRemp.Find(s => s.Id == Convert.ToInt32(id)).Notification.Add(employer.Vacancies.Find(s => s.Id == Convert.ToInt32(id)));
                    var serializer = new JsonSerializer();
                    using (var sw = new StreamWriter($"{PRemp.Find(s => s.Id == Convert.ToInt32(id)).Name}.json"))
                    {
                        using (var jw = new JsonTextWriter(sw))
                        {
                            jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                            serializer.Serialize(jw, PRemp.Find(s => s.Id == Convert.ToInt32(id)));
                        }
                    }
                }
                else
                {
                    throw new Exception("Invalid Vacancy or Employee ID");
                }
            }
            else if (Convert.ToInt32(ch) == 3)
            {
                Console.Clear();
                DSemp.ForEach(s => {
                    Console.WriteLine("================================");
                    Console.WriteLine(s);
                });
                Console.Write("Enter Employee ID: ");
                string id = Console.ReadLine();
                Console.Clear();
                var ds = employer.Vacancies.FindAll(s => s.Profecion == "Design");
                ds.ForEach(s => {
                    Console.WriteLine("================================");
                    Console.WriteLine(s);
                });
                Console.WriteLine("Enter Vacancy ID: ");
                string vid = Console.ReadLine();
                if (DSemp.Find(s => s.Id == Convert.ToInt32(id)) != null && employer.Vacancies.Find(s => s.Id == Convert.ToInt32(id)) != null)
                {
                    DSemp.Find(s => s.Id == Convert.ToInt32(id)).Notification = new List<Vacancy>();
                    DSemp.Find(s => s.Id == Convert.ToInt32(id)).Notification.Add(employer.Vacancies.Find(s => s.Id == Convert.ToInt32(id)));
                    var serializer = new JsonSerializer();
                    using (var sw = new StreamWriter($"{DSemp.Find(s => s.Id == Convert.ToInt32(id)).Name}.json"))
                    {
                        using (var jw = new JsonTextWriter(sw))
                        {
                            jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                            serializer.Serialize(jw, DSemp.Find(s => s.Id == Convert.ToInt32(id)));
                        }
                    }
                }
                else
                {
                    throw new Exception("Invalid Vacancy or Employee ID");
                }
            }
            else
            {
                throw new Exception("Invalid Choose");
            }

        }
        public void EmployerPartVacancies(ref Employer employer)
        {
            Console.Clear();
            Console.WriteLine("1) For Delete");
            Console.WriteLine("2) For Update");
            string ch = Console.ReadLine();

            if (Convert.ToInt32(ch) == 1 || Convert.ToInt32(ch) == 2)
            {
                Console.Clear();
                if (Convert.ToInt32(ch) == 1)
                {
                    employer.Vacancies.ForEach(s => Console.WriteLine(s));
                    Console.WriteLine("Enter Cv Id:");
                    string eid = Console.ReadLine();
                    if (employer.Vacancies.Find(s => s.Id == Convert.ToInt32(eid)) != null)
                    {
                        VacancyRemovePart(ref employer, eid);
                    }
                    else
                    {
                        throw new Exception("Invalid Choose");
                    }
                }
                else if (Convert.ToInt32(ch) == 2)
                {
                    employer.Vacancies.ForEach(s => Console.WriteLine(s));
                    Console.WriteLine("Enter Cv Id:");
                    string eid = Console.ReadLine();
                    if (employer.Vacancies.Find(s => s.Id == Convert.ToInt32(eid)) != null)
                    {
                        VacancyUpdatePart(ref employer, eid);
                    }
                    else
                    {
                        throw new Exception("Invalid Choose");
                    }
                }
                else
                {
                    throw new Exception("Invalid Choose");
                }
            }
            else
            {
                throw new Exception("Invalid Cv or Announcement ID");
            }
        }

        public void VacancyRemovePart(ref Employer employer, string id)
        {
            Console.Clear();
            employer.Vacancies.RemoveAll(s => s.Id == Convert.ToInt32(id));
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter($"{employer.Name}.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, employer);
                }
            }
        }
        public void VacancyUpdatePart(ref Employer employer, string id)
        {
            Console.Clear();
            var cvr = employer.Vacancies.Find(s => s.Id == Convert.ToInt32(id));
            
            Console.Write("Enter UniAccGr: ");
            string uniacc = Console.ReadLine();
            Console.Write("Enter WorkTime: ");
            string wt = Console.ReadLine();
            Console.Write("Enter ForeignL: ");
            string fl = Console.ReadLine();
            Console.Write("Enter SpcD: ");
            string sd = Console.ReadLine();
            Console.Write("Enter Salary: ");
            string sk = Console.ReadLine();
            Console.Write("Enter Description: ");
            string ds = Console.ReadLine();

            int CvId = employer.Vacancies.Count;

            cvr.UniAcceptGrade = Convert.ToInt32(uniacc);
            cvr.WorkTime = wt;
            cvr.ForeignLanguage = fl;
            cvr.HaveSpecialDiplom = Convert.ToBoolean(sd);
            cvr.Salary = Convert.ToDecimal(sk);
            cvr.Description = ds;
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter($"{employer.Name}.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, employer);
                }
            }
        }
    }
}
