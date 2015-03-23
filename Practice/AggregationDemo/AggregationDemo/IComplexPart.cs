using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationDemo
{
    interface IComplexPart : IPart
    {
        List<IPart> Parts { get; set; }
        void TightenParts();
    }
}
