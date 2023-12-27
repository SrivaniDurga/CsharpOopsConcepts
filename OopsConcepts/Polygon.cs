using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class Polygon //Method overriding (Run-Time Polymorphism)
    {
        public virtual void render()
        {
            Console.WriteLine("Rendering polygon");
        }
    }
    class Square : Polygon
    {
        //overriding render() method 
        public override void render()
        {
            Console.WriteLine("Rendering Square");
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            // poly is the object of Polygon class
            Polygon poly = new Polygon();
            // calls render() method of Polygon Superclass 
            poly.render();
            // here, poly is the object of derived class Square 
            poly = new Square();
            // calls render() method of derived class Square
            poly.render();
        }
    }
}
