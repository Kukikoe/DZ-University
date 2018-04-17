using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityClassLibrary
{
    public class Group
    {
        public string GroupName { get; }
        public List<Student> ListOfStudents { get; set; }

        public Group(string GroupName)
        {
            this.GroupName = GroupName;
            ListOfStudents = new List<Student>();
        }

        public override string ToString()
        {
            return GroupName;
        }

        public string ShowListOfStudents()
        {
            return string.Join("\n", ListOfStudents.Select(x => x.GetName()));
        }

    }
}
