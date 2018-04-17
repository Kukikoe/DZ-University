using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityClassLibrary
{
    public class Audience
    {
        public string Number { get; }
        public int NumberOfSeats { get; }

        public Audience(string number, int numOfSeats)
        {
            Number = number;
            NumberOfSeats = numOfSeats;
        }

        public override string ToString()
        {
            return Number;
        }
    }
}
