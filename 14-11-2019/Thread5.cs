using System;
using System.Threading;

public class Program
{
    public void ask()
    {
        Thread t = Thread.CurrentThread;
        Console.WriteLine(t.Name + "is playing");
    }
}
public class Program1
{
    public static void Main(string[] args)
    {
        Program p = new Program();
        Thread t1 = new Thread(p.ask);
        Thread t2 = new Thread(p.ask);
        t1.Name = "Child1";
        t2.Name = "Child2";
        t1.Start();
        t2.Start();
    }
}