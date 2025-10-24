using System;
class arthermati_cal
{
    static void Main()
    {
        Console.WriteLine("enter the one number:");
        int a = Convert.ToInt32(Console.ReadLine());
       
        Console.WriteLine("enter the second number:");
        int b = Convert.ToInt32(Console.ReadLine());
       
        Console.WriteLine("enter the operator:+,-,*,/,%");
        char ope = Convert.ToChar(Console.ReadLine());
        
        int result=0;
        switch (ope)
        {
            case '+':
                result = a + b;
                break;
            case '-' :
                result = a - b;
                break;
            case '*':
                result = a * b;
                break;
            case '/':
                result = a / b;
                break;
            case '%':
                result = a % b;
                break;




        }
        Console.WriteLine(result);
       

    }

    



}

