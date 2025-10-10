using System;
class program
{
    static void Main()
    {
        Stack<string> Stack = new Stack<string>();
        Stack.Push("first");
        Stack.Push("second");
        Stack.Push("third");
        Console.WriteLine(Stack.Pop());
    }
}