using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.TightenParts();

            Console.Write("\n\nPress any key to view all bolt names in the crankshaft.");
            Console.ReadKey();
            Console.WriteLine("\n");
            // This should be abstracted. Just an example of still being able to get specific types...
            foreach (var cs in engine.Parts.Where(t => t.GetType().IsAssignableFrom(typeof (CrankShaft))))
            {
                foreach (var bolt in ((CrankShaft) cs).Parts.Where(t => t.GetType().IsAssignableFrom(typeof (Bolt))))
                {
                    Console.WriteLine(((Bolt)bolt).Name);
                }
            }
            Console.ReadKey();

        }
    }
}
