using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class MethodOverloading
    {
        public void totalSum(int a, int b)
        {
            Console.WriteLine("Sum of two numbers is "+(a+b));
        }
        public void totalSum(double a, double b, double c)
        {
            Console.WriteLine("Sum of three numbers is "+(a+b+c));
        }
        static void Main(string[] args)
        {
            MethodOverloading obj = new MethodOverloading();
            obj.totalSum(4, 5);
            obj.totalSum(2.3, 3.4, 5.6);
        }
    }
}
