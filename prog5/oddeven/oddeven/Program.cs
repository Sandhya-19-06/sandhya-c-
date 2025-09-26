using System.Security.Cryptography.X509Certificates;

namespace oddeven
{


    public class NumberCheck
    {
        public void CheckEvenOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is Even.");
            }
            else
            {
                Console.WriteLine($"{number} is Odd.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            NumberCheck numberCheck = new NumberCheck();
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            numberCheck.CheckEvenOdd(number);
        }
    }
}
   

        