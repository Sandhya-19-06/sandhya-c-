class institute
{
    public void manage()
    {
        Console.WriteLine("institute is managing the student data");
    }
}
class faculty : institute
{
    public void teach()
    {
        Console.WriteLine("faculties are teaching");
    }
}
class student : faculty
{
    public void learn()
    {
        Console.WriteLine("students are learning");
    }
}
class program
{
    static void Main()
    {
        student obj = new student();
        obj.manage();
        obj.teach();
        obj.learn();
    }
}