using System;  
using System.Threading;  
public class MyThread  
{  
    public void read()  
    {  
        for (int i = 0; i < 5; i++)  
        {  
            Console.WriteLine(i);  
            Thread.Sleep(200);  
        }  
    }  
}  
public class ThreadEx  
{  
    public static void Main(String[] args)  
    {  
        MyThread mt = new MyThread();  
        Thread t1 = new Thread(new ThreadStart(mt.read));  
        Thread t2 = new Thread(new ThreadStart(mt.read));  
        Thread t3 = new Thread(new ThreadStart(mt.read));  
        t1.Start();  
        t1.Join();  
        t2.Start();  
        t3.Start();  
    }  
}  