using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class StaticMethods
    {
        public static void EmployeeCount(int empcount)
        {
            Console.WriteLine("Total number of employees in our office are "+empcount);
        }
        public static void Display() {
            Console.WriteLine("I am working in DWP GLobal Corp");
        }

        public static int EmployeeSalary(int empsalary)
        {
            return empsalary;
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        static void Main()
        {
            StaticMethods.EmployeeCount(80);
            StaticMethods.Display();
            Console.WriteLine(StaticMethods.EmployeeSalary(300000));
            Console.WriteLine("addition of two numbers is "+StaticMethods.Add(4,5));

        }
    }
}
//Note: 1)No need of creating objects
//2) call static methods using class name
//3)if you write "static void", then direclty write Console.WriteLine at that point only.
//4)if you write "static and any datatype" then write return at that point. and in the main method , write console.writeline().
//5)we can utalize only static variables inside static methods
