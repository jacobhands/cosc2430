using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11Problem2
{
    /// <summary>
    /// Represents a football team
    /// </summary>
    class FootballTeam : SportTeam
    {

        public override void CallTimeout()
        {
            Console.WriteLine("Calling a timeout in football!");
        }
        public Player QuarterBack { get; set; }
        public FootballTeam(Coach teamHeadCoach) : base(teamHeadCoach)
        {
            
        }

        public override string ToString()
        {
            return base.ToString() + "\nQuarterBack: " + (QuarterBack == null ? "None." : QuarterBack.ToString());
        }
    }
}
