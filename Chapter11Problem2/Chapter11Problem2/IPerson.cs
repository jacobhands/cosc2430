using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11Problem2
{
    // Represent a person
    interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; }
        int Age { get; set; }
        Gender Gender { get; set; }
    }

    enum Gender : byte
    {
        Male,
        Female,
        Other
    }
}
