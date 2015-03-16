using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11Problem2
{
    /// <summary>
    /// Class to represent a sport coach.
    /// </summary>
    class Coach : IPerson
    {
        public Coach(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return FirstName + ' ' + LastName; }
        }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public bool IsHeadCoach { get; set; }
        public override string ToString()
        {
            return FullName + (Age == 0 ? "" : "\nAge: " + Age);
        }
    }
}
