using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class Samsung:Mobile //Inheritance
    {
        public Samsung()
        {
            Console.WriteLine("subclass constructor is called");
        }
        static void Gaming()
        {
            Console.WriteLine("It has a best gaming feature");
        }
        public void Bluetooth()
        {
            Console.WriteLine("It has bluetooth feature");
        }
        static void Main()
        {
            Samsung s = new Samsung();
            s.Communication();
            Samsung.Gaming();
            s.Bluetooth();
        }
    }
}
//Note: static methods can't access through objects. they can access only through class names.
//Non-static methods can access through objects.
