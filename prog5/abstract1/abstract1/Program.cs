using System;
abstract class shape
{
    public abstract double calculatearea();
    public abstract double calculateperimeter();
}
class Circle : shape
{
    private double radius;
    public Circle (double r)
    {
        radius = r;
    }
    public override double calculatearea()
    {
        return Math.PI * radius * radius;
    }
    public override double calculateperimeter()
    {
        return 2 * Math.PI * radius;
    }
}
class Triangle : shape
{
    private double S1, S2, S3;
    public Triangle(double a,double b,double c)
    {
        a = side1;
        b = side2;
        c = side3;
    }
    public override double calculatearea()
    {
        double S = (a + b + c) / 2;
        return Math.Sqrt(S*(S-a)*(S-b)*(S-c));
    }
    public override double calculateperimeter()
    {
        return a+ b+ c;
    }
}
class program
{
    static void Main()
    {
        shape c = new Circle(5);
        Console.WriteLine("circle area:" + c.calculatearea());
        Console.WriteLine("circle perimeter:" + c.calculateperimeter());
        shape t = new Triangle(3, 4, 5);
        Console.WriteLine("triangle area:" + t.calculatearea());
        Console.WriteLine("triangle perimeter:" + t.calculateperimeter());
    }
}