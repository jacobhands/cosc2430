/*
 * Jacob Hands
 * 2015-03-15
 * COSC 2430 001
 * Chapter 11 Problem 2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11Problem2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FootballTeam cowboys = new FootballTeam(new Coach("Jason", "Garrett"));
            cowboys.QuarterBack = new Player("Brandon", "Weeden");
            
            BasketballTeam lakers = new BasketballTeam(new Coach("Byron", "Scott"));
            lakers.Guard = new Player("Jabari", "Brown");

            cowboys.CallTimeout();
            Console.WriteLine("Cowboys Team:\n{0}\n\n", cowboys.ToString());

            lakers.CallTimeout();
            Console.WriteLine("Lakers Team:\n{0}\n", lakers.ToString());

            Console.Write("Press any key.");
            Console.ReadKey();
        }
    }
}
