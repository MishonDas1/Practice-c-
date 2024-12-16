using System;

class HelloWorld
{
    static void Main()
    {
        MyClass myClass = new MyClass();
        ((a)myClass).MyMethod();
        ((b)myClass).MyMethod();
    }

interface a
{
    void MyMethod();
}

interface b
{
    void MyMethod();
}

class MyClass : a, b
{
    void a.MyMethod()
    {
        Console.WriteLine("a.MyMethod implementation");
    }

    void b.MyMethod()
    {
        Console.WriteLine("b.MyMethod implementation");
    }
}


}
