// Jacob Hands
// 2015-03-29
// COSC 2430 001
// Chapter 11 Problem 4 (page 773)
using System;

namespace Chappter11Problem4
{
    /// <summary>
    /// Represents a football team
    /// </summary>
    public class FootballTeam : SportTeam, IBudgetable
    {

        public override string CallTimeout()
        {
            return "Calling a timeout in football!";
        }
        public Player QuarterBack { get; set; }
        public FootballTeam(Coach teamHeadCoach) : base(teamHeadCoach)
        {
            
        }

        public override string ToString()
        {
            return base.ToString() + "\nQuarterBack: " + (QuarterBack == null ? "None." : QuarterBack.ToString());
        }

        // Budget stuff

        public float Budget { get; set; }
        public DateTime CurrentTaxYear { get; set; }

        public void TakeLoan(float amount)
        {
            CurrentLoan += amount;
            CashOnHand += amount;
            GrossTotalAssets += amount;
        }

        public void PayLoan(float amount)
        {
            CurrentLoan -= amount;
            CashOnHand -= amount;
            GrossTotalAssets -= amount;
        }
        public float CurrentLoan { get; set; }
        public float CashOnHand { get; set; }
        public float GrossTotalAssets { get; set; }
    }
}
