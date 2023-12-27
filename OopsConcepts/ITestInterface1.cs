using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal interface ITestInterface1 //parent interface
    {
        void Add(int a, int b); //abstract method
    }
    interface ITestInterface2 : ITestInterface1 //child interface(inheritance)
    {
        void Sub(int a, int b); //abstract method
    }
    class MyClass : ITestInterface2 //implimentation will done in this class
    {
        public void Add(int a, int b) //no need to write override keyword in interface concept.just write public keyword while implimenting
        {
            Console.WriteLine("Addition of two numbers is "+a+b);
        }
        public void Sub(int a, int b) //if you don't write public keyword, it'll give you error.
        {
            Console.WriteLine("Subtraction of two numbers is "+ (a - b));
        }
        static void Main()
        {
            MyClass obj = new MyClass();
            obj.Add(6,7);
            obj.Sub(25, 5);
        }

        /*internal void Test()
        {
            throw new NotImplementedException();
        }*/
    }
}
