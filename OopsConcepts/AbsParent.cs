using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal abstract class  AbsParent //Abstraction
    {
        public void Add(int x, int y) //Non-abstract method
        {
            Console.WriteLine(x+y);
        }
        public void Sub(int x, int y) //Non-abstract method
        {
            Console.WriteLine(x-y);
        }
        public abstract void Mul(int x, int y); //abstract method 
        public abstract void Div(int x, int y); //abstract method
    }
}
//Note: We can't create instance of the Abstract class. 