using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHUtilities
{
    static class Utils
    {
        public static void PressAnyKey()
        {
            Console.Write("\n\nPress any key.");
            Console.ReadKey();
        }
    }
}
