using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

public class Program {
    public static void Main(string[] args)
    {
       callMethod();
    }
    public static async void callMethod()
    {
        Task<int> task = Method1();
        Method2();
        int count = await task;
        Method3(count);
    }
    public static async Task<int> Method1()
    {
        int count = 0;
        await Task.Run(() =>
        {
            for(int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Method1()");
                count += 1;
            }
        });
        return count;
    }
    public static  void Method2()
    {
        for(int i = 0; i <= 25; i++)
        {
            Console.WriteLine("Method2()");
        }
    }
    public static void Method3(int count)
    {
        Console.WriteLine("Total count is {0} ", count);
    }
}