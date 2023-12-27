using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts; //multiple interface example

internal interface ParentInterface //parent interface
{
    void Test();
}
interface childInterface : ParentInterface //child interface inheriting parent interface
{
    void Test();
}
class MultipleInheritance : ParentInterface, childInterface
{
    public void Test()
    {
        Console.WriteLine("Interfaces method implimented in child class");
    }
    static void Main()
    {
        MultipleInheritance obj = new MultipleInheritance();
        obj.Test();
    }
}
