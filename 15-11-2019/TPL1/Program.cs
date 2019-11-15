using System;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
       Task t1 = Task.Factory.StartNew(() => DoWork(1, 1000)).ContinueWith((prev) => DoOtherWork(1,1500)); //lambda expression internally invoking dowork method
        
        Task  t2 = Task.Factory.StartNew(() => DoWork(2, 2000));
       
       Task t3 = Task.Factory.StartNew(() => DoWork(3, 2000));
       
        Console.ReadKey();
    }
    static void DoWork(int id, int sleep)
    {
        Console.WriteLine("Task {0} is beginning....", id);
        Thread.Sleep(sleep);
        Console.WriteLine("Task {0} is completed...", id);
    }
    static void DoOtherWork(int id, int sleep)
    {
        Console.WriteLine("Other Task {0} is beginning....",id);
        Thread.Sleep(sleep);
        Console.WriteLine("Other Task{0} is completed...",id);
    }
}
