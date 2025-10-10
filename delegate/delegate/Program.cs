using System;
delegate void Greet();
class program
{
    static void sayHello()
    {
        Console.WriteLine("Hello, Student");

    }
    static void Main()
    {
        Greet greetdelegate = sayHello;
        greetdelegate();
    }
}