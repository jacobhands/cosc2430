using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12Problem8
{
    public class Calculator
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Result { get; set; }

        public void Multiply()
        {
            Result = Num1*Num2;
        }

        public void Devide()
        {
            if (Num2.Equals(0D))
            {
                throw new DevideByZeroException();
            }
            else
            {
                Result = Num1 / Num2;
            }
        }

        public void Add()
        {
            Result = Num1 + Num2;
        }

        public void Subtract()
        {
            Result = Num1 - Num2;
        }

    }
}
