using System;
public class Program
{
	public static void Main(String[] args)
	{
		 DateTime date1, date2;
      DateTimeOffset dateOffset1, dateOffset2;
      TimeSpan difference;
      
      // Find difference between Date.Now and Date.UtcNow
      date1 = DateTime.Now;
      date2 = DateTime.UtcNow;		//coordinated universal time
      difference = date1 - date2;
      Console.WriteLine("{0} - {1} = {2}", date1, date2, difference);
      
      // Find difference between Now and UtcNow using DateTimeOffset
      dateOffset1 = DateTimeOffset.Now;
      dateOffset2 = DateTimeOffset.UtcNow;
      difference = dateOffset1 - dateOffset2;
      Console.WriteLine("{0} - {1} = {2}", 
                        dateOffset1, dateOffset2, difference);
    

	}
	
}
		