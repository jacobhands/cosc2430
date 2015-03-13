using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JHFactories;

namespace JHUtilities
{
    public static class ConsoleHelper
    {
        public static string GetString()
        {
            return Class1.PrintThing() + " We are in Consolehelper!";
        }
    }
}
