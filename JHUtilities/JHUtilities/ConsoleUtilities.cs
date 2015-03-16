using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHUtilities
{
    public static class ConsoleHelper
    {
        //public static void PressAnyKey(this Console)
        public static void PressAnyKey()
        {
            Console.Write("\n\nPress any key.");
            Console.ReadKey();
        }

        public static T AndPressAnyKey<T>(this T obj)
        {
            PressAnyKey();
            return obj;
        }
    }

}
