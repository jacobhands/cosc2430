using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AggregationDemo
{
    class Bolt : IPart, ITightenable
    {
        public string Type { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public string Name { get; set; }
        public bool Tighten()
        {
            // Make it fale sometimes.
            Random rnd = new Random(Type.GetHashCode());
            Console.WriteLine("Trying to tighten bolt: {0}", Name);
            return rnd.NextDouble() > 0.5D;
        }

        public Bolt(string boltName, string boltType, float boltLength, float boltWidth)
        {
            Type = boltType;
            Length = boltLength;
            Width = boltWidth;
            Type = boltType;
            Name = boltName;
        }
    }
}
