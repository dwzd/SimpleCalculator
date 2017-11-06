using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public abstract class Calcu
    {
        public double NumberOne
        {
            get; set;
        }
        public double NumberTwo
        {
            get; set;
        }
        public Calcu(double n1, double n2)
        {
            this.NumberOne = n1;
            this.NumberTwo = n2;
        }

        public abstract double GetResult();
        
    }
}
