using System;
using System.Globalization;
class Shape
{
    public virtual void draw() => Console.WriteLine("drawing a shape..");
    public virtual void erase() => Console.WriteLine("earsing a shape");
}
class circle:Shape
{
    public override void draw() => Console.WriteLine("drawing a shape..");
    public override void erase() => Console.WriteLine("earsing a shape");
}
class triangle : Shape
{
    public override void draw() => Console.WriteLine("drawing a shape..");
    public override void erase() => Console.WriteLine("earsing a shape");
}
class square:Shape
{
    public override void draw() => Console.WriteLine("drawing a shape..");
    public override void erase() => Console.WriteLine("earsing a shape");
}
class program
{
    static void Main()
    {


        Shape s;
        s = new circle();
        s.draw();
        s.erase();
        s = new triangle();
        s.draw();
        s.erase();
        s = new square();
        s.draw();
        s.erase();

    }
}