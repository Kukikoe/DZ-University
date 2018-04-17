using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityClassLibrary
{
    public class Teacher
    {
        public string Name { get; }
        public string Surname { get; }
        public List<Audience> ListOfAudiences { get; set; }
        public List<Subject> ListOfSubjects { get; set; }

        public Teacher(string name, string surname)
        {
            Name = name;
            Surname = surname;
            ListOfSubjects = new List<Subject>();
            ListOfAudiences = new List<Audience>();
        }
        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
        public string ShowListOfAudiences()
        {
            return string.Join(", ", ListOfAudiences.Select(x => x.ToString()));
        }
        public string ShowListOfSubjects()
        {
            return string.Join(", ", ListOfSubjects.Select(x => x.ToString()));
        }
        

    }
}
