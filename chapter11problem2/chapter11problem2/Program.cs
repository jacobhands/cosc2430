using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JHUtilities;

namespace chapter11problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            input.GetUserInput("Enter a number", clearOnError: true);
            Console.WriteLine(JHUtilities.ConsoleHelper.GetString());
            Console.WriteLine(input);
           // PressAnyKey();
        }
    }
}
