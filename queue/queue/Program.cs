using System;
class program
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("first");
        queue.Enqueue("second");
        Console.WriteLine(queue.Dequeue());
    }
}