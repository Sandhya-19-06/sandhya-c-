using System;

interface Resizable
{
    void Resizewidth(int width);
    void Resizeheight(int height);

}
class Rectangle : Resizable
{
    private int width;
    private int height;
}
public Rectangle (int width,int height)
{
    this.width = width;
    this.height = height;

}
public void Resizewidth(int width)
{
    this.width = width;
    Console.WriteLine("resized width to:" + width);
}
public void Resizeheight(int height)
{
    this.height = height;
    Console.WriteLine("resized height to :" + height);
}
public void display()
{
    Console.WriteLine("rectangle[width:" + width + ",height:" + height + "]");
}
}
class program
{
    static void Main()
    {
        Rectangle r = new Rectangle(10, 20);
        r.display();
        r.Resizewidth(30);
        r.Resizeheight(40);
        r.display();
    }
}