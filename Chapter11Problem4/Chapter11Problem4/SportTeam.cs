// Jacob Hands
// 2015-03-29
// COSC 2430 001
// Chapter 11 Problem 4 (page 773)
using System;

namespace Chappter11Problem4
{
    /// <summary>
    /// Represents a sports team
    /// </summary>
    public abstract class SportTeam
    {
        public Coach HeadCoach { get; set; }

        // Constructor
        protected SportTeam(Coach teamHeadCoach)
        {
            HeadCoach = teamHeadCoach;
        }

        // Virtual methods
        public virtual string CallTimeout()
        {
            return "Calling timeout!";
        }
        // Overrides
        public override string ToString()
        {
            return  "Head Coach: " + (HeadCoach == null ? "None." : HeadCoach.ToString());
        }
    }
}
