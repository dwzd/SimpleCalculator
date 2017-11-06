using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Sub : Calcu
    {
        public override double GetResult()
        {
            return this.NumberOne - this.NumberTwo;
        }
        public Sub(double n1, double n2) : base(n1, n2)
        {

        }
    }
}
