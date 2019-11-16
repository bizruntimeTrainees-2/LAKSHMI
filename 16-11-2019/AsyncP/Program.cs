using System;

using System.Threading;
using System.Threading.Tasks;

class Program
{
    public static async Task Main()
    {
        Task<DayOfWeek> t = new Task<DayOfWeek>(() => DateTime.Today.DayOfWeek);

        await t.ContinueWith(antecedent => Console.WriteLine("Today is {0} ", antecedent.Result));
    }
}