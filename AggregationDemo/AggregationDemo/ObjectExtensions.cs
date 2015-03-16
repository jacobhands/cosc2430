using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationDemo
{
    static class ObjectExtensions
    {
        public static bool InheritsFromInterface(this object obj, Type interfaceType)
        {
            return obj.GetType().GetInterfaces().Contains(interfaceType);
        }
    }
}
