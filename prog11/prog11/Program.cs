using System.Diagnostics;

class system;
class program1
{
    static void Main()
    {
        Console.WriteLine("enter the number");
        int n = Convert.ToInt32(Console.ReadLine());
        int lastdigit = n % 10;
        int firstdigit = n;
        while (firstdigit >= 10)
        {
            firstdigit /= 10;
        }
        Console.WriteLine("firstdigit: " + firstdigit);
        Console.WriteLine("lastdigit: "  + lastdigit);
    }
}
