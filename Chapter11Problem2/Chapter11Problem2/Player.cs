using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11Problem2
{
    class Player : IPerson
    {
        public Player(string firstName, string lastName)
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

        public override string ToString()
        {
            return FullName;
        }
    }
}
