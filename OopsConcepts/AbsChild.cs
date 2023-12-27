using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class AbsChild : AbsParent
    {
        public override void Mul(int x, int y) //implementing parent class in the child class
        {
            Console.WriteLine(x * y);
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        static void Main()
        {
            AbsChild c = new AbsChild();
            c.Add(5, 6);
            c.Sub(8, 4);
            c.Mul(2, 2);
            c.Div(6, 2);
        }
    }
}