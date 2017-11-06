using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Please input the First Number:");
                double numberOne = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please give the Second Number:");
                double numberTwo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please choose the Operator:");
                string oper = Console.ReadLine();
                Calcu calc = GetCalcu(oper, numberOne, numberTwo);
                Console.WriteLine("Result = {0}", calc.GetResult());
                Console.ReadLine();
            }
        }
        public static Calcu GetCalcu(string opera, double n1, double n2)
        {
            Calcu calcu = null;
            switch (opera)
            {
                case "+":
                    calcu = new Add(n1, n2);
                    break;
                case "-":
                    calcu = new Sub(n1, n2);
                    break;
                case "*":
                    calcu = new Multi(n1, n2);
                    break;
                case "/":
                    calcu = new Divi(n1, n2);
                    break;
            }
            return calcu;
        }
    }
}
