using System;
using System.Collections.Generic;
using System.Threading;

public class Program
{
    public static void Main()
	{
        Thread t1 = new Thread(new ThreadStart(Demo.Eat));
        
        t1.Start();
       
    }
}
public class Demo
{
    public  static void Eat()
    {
		for(int i = 1; i < 100; i++)
		{
        Console.WriteLine(i);
		}
    }
}