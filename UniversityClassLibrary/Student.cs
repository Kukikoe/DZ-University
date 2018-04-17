using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityClassLibrary
{
    public class Student
    {
        public string Name { get; }
        public string Surname { get; }
        public List<Mark> ListOfMarks { get; set; }

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
            ListOfMarks = new List<Mark>();
        }
        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
        public string GetName()
        {
            return $"{Name.PadLeft(20)} {Surname}";
        }

        public string GradeToString() 
        {
            return string.Join(", ", ListOfMarks.Select(x => x.Subjects.ToString() + " - " + x.ToString()));
        }
    }
}
