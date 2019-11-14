using System;
using System.Threading;
public class Demo
{
    public void read()
    {
        Console.WriteLine("reading");
    }
    public void write()
    {
        Console.WriteLine("writing");
    }
    public static void Main(string[] args)
    {
        Demo d = new Demo();
        Thread t1 = new Thread(d.read);
        Thread t2 = new Thread(d.write);
        t1.Start();
        t2.Start();
    }
}