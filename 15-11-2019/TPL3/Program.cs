using System;
using System.Threading.Tasks;

public class Example
{
    public static async Task Main()
    {
        var t = Task.Run(() => {
            DateTime date = DateTime.Now;
            if (date == DateTime.MinValue)
                throw new ArgumentException("The clock is not working.");

            if (date.Hour > 17)
                return "evening";
            else if (date.Hour > 12)
                return "afternoon";
            else
                return "morning";
        });
        await t.ContinueWith((antecedent) => {
            Console.WriteLine("Good {0}!",
                                antecedent.Result);
            Console.WriteLine("And how are you this fine {0}?",
                              antecedent.Result);
        },
                                TaskContinuationOptions.OnlyOnRanToCompletion);
    }
}
