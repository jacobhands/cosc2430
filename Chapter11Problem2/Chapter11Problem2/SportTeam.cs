using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11Problem2
{
    /// <summary>
    /// Represents a sports team
    /// </summary>
    abstract class SportTeam
    {
        public Coach HeadCoach { get; set; }

        // Constructor
        protected SportTeam(Coach teamHeadCoach)
        {
            HeadCoach = teamHeadCoach;
        }

        // Virtual methods
        public virtual void CallTimeout()
        {
            Console.WriteLine("Calling timeout!");
        }
        // Overrides
        public override string ToString()
        {
            return  "Head Coach: " + (HeadCoach == null ? "None." : HeadCoach.ToString());
        }
    }
}
