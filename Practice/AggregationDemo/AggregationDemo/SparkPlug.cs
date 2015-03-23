using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AggregationDemo
{
    class SparkPlug : IPart, ITightenable
    {
        public string Name { get; set; }
        public bool Tighten()
        {
            Console.WriteLine("Trying to tighten Sparkplug: {0}", Name);
            Random rnd = new Random(Name.GetHashCode());
            return rnd.NextDouble() > 0.5D;
        }

        public SparkPlug()
        {
            Name = "A default sparkplug!";
        }

    }
}
