using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationDemo
{
    class Part : IPart
    {
        public string Name { get; set; }

        public Part(string partName)
        {
            Name = partName;
        }

        public Part() { }
    }
}
