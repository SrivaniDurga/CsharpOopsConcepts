using System;
struct MyStruct
{
    int i;
    public void Display()
    {
        Console.WriteLine("I am an employee in DWP Global Corp "+i);
    }
    static void Main()
    {
        MyStruct m1;
        m1.i = 10;
        m1.Display();

        MyStruct m2 = new MyStruct();
        m2.Display();
        
    }
}
//Note: if you assign i value at the time of initialization, means if you gave i value in step 4,
//it will give error. bcz in "Structure" we can't assign values at the time of variable declaration. but in classes we can assign like that.
//you can give  MyStruct m= new Mystruct(); but it will give you only default values at that time.
