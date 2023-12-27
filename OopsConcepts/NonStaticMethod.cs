using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class NonStaticMethod
    {
        public void Display()
        {
            Console.WriteLine("Today is Monday");
        }
        public void Show(bool b) //return type is void
        {
            Console.WriteLine("Sun rises in the west is "+b);
        }
        public int  EmployeeCount(int empCount) //return typeis int
        {
            return empCount;
        }
        public static void Main()
        {
            NonStaticMethod ns = new NonStaticMethod();
            ns.Display();
            ns.Show(false);
            Console.WriteLine("Employee count is "+ns.EmployeeCount(80));
           
        }
    }
}
