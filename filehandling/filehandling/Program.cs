using System;
using System.IO;
class program
{
    static void Main()
    {
        File.WriteAllText("notes.txt", "File Handling in c# is easy ! \n lets read this file next.");
        String content = File.ReadAllText("notes.txt");
        Console.WriteLine("File content:\n" + content);
    }
}
