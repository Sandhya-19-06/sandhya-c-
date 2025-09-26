using System;
class program
{
    static void Main()
    {
        Console.WriteLine("enter a sentence:");
        string s = Convert.ToString(Console.ReadLine());
        string[] words = s.Split(' ');
        Array.Reverse(words);
        Console.WriteLine(string.Join(" ", words));

    }
}



