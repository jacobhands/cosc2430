using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11Problem2
{
    /// <summary>
    /// Represents a basketball team
    /// </summary>
    class BasketballTeam : SportTeam
    {

        public override void CallTimeout()
        {
            Console.WriteLine("Calling a timeout for basketball!");
        }
        public Player Guard { get; set; }
        public BasketballTeam(Coach teamHeadCoach) : base(teamHeadCoach)
        {
            
        }

        public override string ToString()
        {
            return base.ToString() + "\nPoint Guard: " + (Guard == null ? "None." : Guard.ToString());
        }
    }
}
