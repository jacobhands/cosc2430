// Jacob Hands
// 2015-03-29
// COSC 2430 001
// Chapter 11 Problem 4 (page 773)
namespace Chappter11Problem4
{
    // Represent a person
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; }
        int Age { get; set; }
        Gender Gender { get; set; }
    }

    public enum Gender : byte
    {
        Male,
        Female,
        Other
    }
}
