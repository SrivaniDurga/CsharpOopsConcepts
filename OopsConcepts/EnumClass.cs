using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
     // making an enumerator 'month' 
     enum month
        {
           // following are the data members
           jan,
           feb,
           mar,
           apr,
           may
     }
     class EnumClass
       {
           // Main Method
           static void Main(string[] args)
           {
                // getting the integer values of data members..
                Console.WriteLine("The value of jan in month " +
                                  "enum is " + (int)month.jan);
                Console.WriteLine("The value of feb in month " +
                                  "enum is " + (int)month.feb);
                Console.WriteLine("The value of mar in month " +
                                  "enum is " + (int)month.mar);
                Console.WriteLine("The value of apr in month " +
                                  "enum is " + (int)month.apr);
                Console.WriteLine("The value of may in month " +
                                  "enum is " + (int)month.may);
           }
     }
}

//Note: 1) It is mainly used to assign the names or string values to integral constants, that make a program easy to read and maintain.
//2) 

