using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHUtilities
{
    public static class Extensions
    {
        /// <summary>
        /// Get user input with specified return type
        /// </summary>
        /// <returns>User input</returns>
        public static T GetUserInput<T>(this T obj, string prompt, bool clearOnError = false) where T : struct
        {
            bool err = false;
            T input = new T();
            do
            {
                try
                {
                    Console.Write(prompt);
                    input = (T) Convert.ChangeType(Console.ReadLine(), typeof (T));
                    err = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR: {0}", e.Message);
                    Utils.PressAnyKey();
                    if (clearOnError) Console.Clear();
                    err = true;
                }
            } while (err);
            return input;
        }

        
    }
}
