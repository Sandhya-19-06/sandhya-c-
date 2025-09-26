using System;
using System.IO;
class program
{
    static void Main()
    {
        using(StreamWriter writer =new StreamWriter("data.txt"))
        {
            writer.WriteLine("Name : Laxmi");
            writer.WriteLine("course : BCA");

        }
        using(StreamReader reader=new StreamReader("data.txt"))
        {
            String line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine("File" + line);
            }
        }
    }
}