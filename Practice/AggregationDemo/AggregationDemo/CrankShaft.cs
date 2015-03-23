using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationDemo
{
    class CrankShaft : ComplexPart
    {
        public override void CreateParts()
        {
            Parts.AddRange(
                new List<IPart>
                {
                    new Bolt("A strong bolt", "A1", 3, 1),
                    new Bolt("Another bolt", "A2", 5, 1),
                    new Bolt("Yet another bolt!", "A3", 1, 1.2F)
                });
        }

        public CrankShaft()
        {
            Name = "A default crankshaft";
        }
    }
}
