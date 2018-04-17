using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityClassLibrary
{
    public class Specialty
    {
        public string SpecialtyName { get; }
        public List<Group> ListOfGroups { get; set; }

        public Specialty(string SpecialtyName)
        {
            this.SpecialtyName = SpecialtyName;
            ListOfGroups = new List<Group>();
        }

        public override string ToString()
        {
            return SpecialtyName;
        }

        public string ShowListOfGroups()
        {
            return string.Join("\n", ListOfGroups.Select(x => x.ToString()));
        }
    }
}
