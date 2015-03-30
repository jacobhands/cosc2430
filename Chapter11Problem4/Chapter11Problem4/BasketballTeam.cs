// Jacob Hands
// 2015-03-29
// COSC 2430 001
// Chapter 11 Problem 4 (page 773)
using System;

namespace Chappter11Problem4
{
    /// <summary>
    /// Represents a basketball team
    /// </summary>
    public class BasketballTeam : SportTeam, IBudgetable
    {

        public override string CallTimeout()
        {
            return "Calling a timeout for basketball!";
        }
        public Player Guard { get; set; }
        public BasketballTeam(Coach teamHeadCoach) : base(teamHeadCoach)
        {
            
        }

        public override string ToString()
        {
            return base.ToString() + "\nPoint Guard: " + (Guard == null ? "None." : Guard.ToString());
        }

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
