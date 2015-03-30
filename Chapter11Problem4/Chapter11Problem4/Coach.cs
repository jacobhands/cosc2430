// Jacob Hands
// 2015-03-29
// COSC 2430 001
// Chapter 11 Problem 4 (page 773)
namespace Chappter11Problem4
{
    /// <summary>
    /// Class to represent a sport coach.
    /// </summary>
    public class Coach : IPerson
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
