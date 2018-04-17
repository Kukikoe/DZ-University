using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityClassLibrary
{
    public class Subject
    {
        public string SubjectName { get;  }
       // public List<Teacher> ListOfTeachers { get; set; }

        public Subject(string SubjectName)
        {
            this.SubjectName = SubjectName;
            //ListOfTeachers = new List<Teacher>();
        }
        public override string ToString()
        {
            return SubjectName;
        }
        //public string ShowListOfTeachers()
        //{
        //    return string.Join("\n", ListOfTeachers.Select(x => x.ToString()));
        //}
    }
}
