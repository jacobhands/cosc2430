using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationDemo
{
    class Piston : ComplexPart
    {
        public override void CreateParts()
        {
            Parts.Add(new Part("Metal thing 1"));
            Parts.Add(new Part("Metal thing 2"));
        }
    }
}
