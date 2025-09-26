class animal
{
    public void eat()
    {
        Console.WriteLine("animal is eating");

    }
}
    class dog : animal
    {
        public void bark()
        {
            Console.WriteLine("dog is barking");
        }
    }
class program
{
    static void Main()
    {
        dog d = new dog();
        d.eat();
        d.bark();
    }
}