using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class MethodOverriding
    {
        public virtual void totalSum(int a, int b)
        {
            Console.WriteLine("Sum a and b is " + (a + b));
        }
    }
    class SubClass : MethodOverriding
    {
        public override void totalSum(int a, int b)
        {
            Console.WriteLine("Division of a and b is " + (a/b));
        }
        static void Main(string[] args)
        {
            SubClass s = new SubClass();
            s.totalSum(8, 2);
        }
    }
        
 }

