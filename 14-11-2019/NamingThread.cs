using System;
using System.Threading;

public class T1
{
    public static void Main(string[] args)
    {
        Thread t = Thread.CurrentThread;
        t.Name = "Main Thread";
        Console.WriteLine("current executed Thread is: " + Thread.CurrentThread.Name);
    }
}