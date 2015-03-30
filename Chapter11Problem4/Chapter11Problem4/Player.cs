// Jacob Hands
// 2015-03-29
// COSC 2430 001
// Chapter 11 Problem 4 (page 773)
namespace Chappter11Problem4
{
    public class Player : IPerson
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
