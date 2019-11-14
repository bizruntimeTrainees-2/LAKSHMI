using System;
using System.Threading;
public class Program
{
    public void walk()
    {
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
    }
}
public class MyThread
{
    public static void Main()
    {
        Console.WriteLine("Main Begin");
        Program p = new Program();
        Thread t1 = new Thread(p.walk);
        Thread t2 = new Thread(p.walk);
        t1.Start();
        t2.Start();
try
{
    t1.Abort();
    t2.Abort();

}
catch (ThreadAbortException ae)
{
    Console.WriteLine(ae.ToString());
}
Console.WriteLine("Main End");
}
}
