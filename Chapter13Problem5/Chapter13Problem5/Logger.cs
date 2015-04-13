using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13Problem5
{
    class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
            Console.Write("\nPress any key.");
            Console.ReadKey();
        }
    }
}
