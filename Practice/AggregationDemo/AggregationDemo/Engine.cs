using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationDemo
{
    class  Engine : ComplexPart
    {
        public override void CreateParts()
        {
            Parts.Add(new CrankShaft());
            Parts.Add(new Piston());
            Parts.Add(new SparkPlug());
        }
    }
}
