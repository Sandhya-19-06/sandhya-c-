using System;
class sum_of_digits
{
   static void Main()
    {
        Console.WriteLine("enter the digits:");
        int num = Convert.ToInt32(Console.ReadLine());
        
        int sum = 0, rem;
        while (num > 0)
        {
            rem = num % 10;
            sum += rem;
            num /= 10;
        }
        Console.WriteLine("sum of digit is "  +  sum);
    }
}