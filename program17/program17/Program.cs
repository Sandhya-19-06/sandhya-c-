class program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 / num2;
            Console.WriteLine("result:" + result);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("error : cannot be divided by zero");
        }
        catch (FormatException)
        {
            Console.WriteLine(" cannot divide");

        }
        finally
        {
            Console.WriteLine("CODE EXECUTED");
        }




}
}