// Jacob Hands
// 2015-03-29
// COSC 2430 001
// Chapter 11 Problem 4 (page 773)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chappter11Problem4
{
    public interface IBudgetable
    {
        float Budget { get; set; }
        DateTime CurrentTaxYear { get; set; }
        void TakeLoan(float amount);
        void PayLoan(float amount);
        float CurrentLoan { get; set; }
        float CashOnHand { get; set; }
        float GrossTotalAssets { get; set; }
    }
}
