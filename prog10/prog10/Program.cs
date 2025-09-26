using System;
class program
{
    static void Main()
    {
        Console.WriteLine("enter the string");
        string str = Convert.ToString(Console.ReadLine());
        string str1 = str.Substring(0, 6);
        Console.WriteLine(str1);

    }
}