class car
{
    public void enginee()
    {
        Console.WriteLine("enginee started");

    }
}
class honda : car
{
    public void brand()
    {
        Console.WriteLine("name of the brand is honda");
  
    }
}
class kia : car
{
    public void company()
    {
        Console.WriteLine("name of the company");
    }
}
class program
{
    static void Main() 
    {
        kia obj = new kia();
        honda obj1 = new honda();
        obj.enginee();
        obj1.brand();
        obj.company();
    }
}