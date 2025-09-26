using System;
class Myclass
{
    private int Age;
        public void showage()
    {
        Console.WriteLine("enter the age:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("AGE IS " +age);
    }

}
class program
{
    static void Main()
    {
        Myclass obj = new Myclass();
        obj.showage();
    }
}