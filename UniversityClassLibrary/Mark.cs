using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityClassLibrary
{
    public class Mark
    {
        public int Grade { get; }
        public Subject Subjects { get; }

        public Mark (Subject Subjects, int grade)
        {
            this.Subjects = Subjects;
            Grade = grade;
            if(grade <= 0 || grade > 100)
            {
                throw new Exception("Scale is not supported format!");
            }
        }

        public override string ToString()
        {
            if (Grade >= 0 && Grade <= 19)
            {
                return Grade.ToString() + "(F)";
            }
            if (Grade >= 20 && Grade <= 39)
            {
                return Grade.ToString() + "(E)";
            }
            if (Grade >= 40 && Grade <= 59)
            {
                return Grade.ToString() + "(D)";
            }
            if (Grade >= 60 && Grade <= 74)
            {
                return Grade.ToString() + "(C)";
            }
            if (Grade >= 75 && Grade <= 89)
            {
                return Grade.ToString() + "(B)";
            }
            if (Grade >= 90 && Grade <= 100)
            {
                return Grade.ToString() + "(A)";
            }
            else return "Error!";
        }
    }
}
