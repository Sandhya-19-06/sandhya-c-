using System;
interface camera
{
    void capture();

}
interface printer
{
    void print();

}
class advance : camera , printer
{
    public void capture()
    {
        Console.WriteLine("capture the photo");
    }
    public void print()
    {
        Console.WriteLine("print the photo");
    }
}
class program
{
    static void Main()
    {
        advance a = new advance();
        a.capture();
        a.print();
    }
}