using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12Problem8
{
    public class DevideByZeroException: Exception
    {
        public DevideByZeroException()
        {
            
        }

        public DevideByZeroException(string message) : base(message)
        {
            
        }

        public DevideByZeroException(string message, Exception inner)
            : base(message, inner)
        {
            
        }
    }
}
