using System;
class animal
{
    protected void makesound()
    {
        Console.WriteLine("some sound");

    }
}
class dog : animal
{
    public void bark()
    {
        makesound();
        Console.WriteLine("dog is barking");
    }
    
}
class prog
{
    static void Main()
    {
        dog d = new dog();
        d.bark();
    }
}